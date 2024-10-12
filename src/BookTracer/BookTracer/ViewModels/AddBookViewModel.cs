using BookTracer.Domain.Domains;
using BookTracer.Domain.Repositories;
using BookTracer.Events;
using BookTracer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracer.ViewModels
{
    public class AddBookViewModel : INotifyPropertyChanged, IDisposable
    {
        private readonly IBookRepository bookRepository;
        private readonly IAuthorRepository authorRepository;

        public AddBookViewModel(IBookRepository bookRepository
            , IAuthorRepository authorRepository)
        {
            this.bookRepository = bookRepository;
            this.authorRepository = authorRepository;
            AuthorsDataSource = new List<string>();

            authors = authorRepository.RetrieveAll();
            foreach (var author in authors)
                AuthorsDataSource.Add($"{author.LastName.Trim()} {author.FirstName.Trim()}");
        }

        #region Properties
        private int rate;
        private List<IAuthor> authors;
        public List<string> AuthorsDataSource { get; set; }
        public bool FirstRate { get; set; }
        public bool SecondRate { get; set; }
        public bool ThirdRate { get; set; }
        public bool FourthRate { get; set; }
        public bool FifthRate { get; set; }
        private bool isNewAuthor;
        public bool IsNewAuthor
        {
            get => isNewAuthor;
            set
            {
                isNewAuthor = value;
                OnPropertyChanged(nameof(IsNewAuthor));
            }
        }
        private bool isExistingAuthor;
        public bool IsExistingAuthor
        {
            get => isExistingAuthor;
            set
            {
                isExistingAuthor = value;
                OnPropertyChanged(nameof(IsExistingAuthor));
            }
        }
        private string authorFirstName;
        public string AuthorFirstName
        {
            get => authorFirstName;
            set
            {
                authorFirstName = value;
                OnPropertyChanged(nameof(AuthorFirstName));
            }
        }
        private string authorLastName;
        public string AuthorLastName
        {
            get => authorLastName; set
            {
                authorLastName = value;
                OnPropertyChanged(nameof(AuthorLastName));
            }
        }
        private string bookName;
        public string BookName
        {
            get => bookName; set
            {
                bookName = value;
                OnPropertyChanged(nameof(BookName));
            }
        }
        #endregion
        public void OnRateBoxClick(RateBoxClickEvent args)
        {
            bool changeToFullStar = true;
            string pictureBoxName = string.Empty;
            switch (args.RateBox)
            {
                case RateBox.First:
                    FirstRate = !FirstRate;
                    pictureBoxName = "pictureBoxFirstStar";
                    rate = 1;
                    break;
                case RateBox.Second:
                    SecondRate = !SecondRate;
                    pictureBoxName = "pictureBoxSecondStar";
                    rate = 2;
                    break;
                case RateBox.Third:
                    ThirdRate = !ThirdRate;
                    pictureBoxName = "pictureBoxThridStar";
                    rate = 3;
                    break;
                case RateBox.Fourth:
                    FourthRate = !FourthRate;
                    pictureBoxName = "pictureBoxFourthStar";
                    rate = 4;
                    break;
                case RateBox.Fifth:
                    FifthRate = !FifthRate;
                    pictureBoxName = "pictureBoxFifthStar";
                    rate = 5;
                    break;
            }
            foreach (var pictureBox in args.PictureBoxes)
            {
                pictureBox.Image = changeToFullStar ? Resources.yellow_star : Resources.white_star;

                if (pictureBoxName.Equals(pictureBox.Name))
                    changeToFullStar = false;
            }
        }
        public void OnAdd()
        {
            try
            {
                if (!Validate())
                    return;

                var book = bookRepository.Create();
                IAuthor? author = null;
                if (IsExistingAuthor)
                    author = authorRepository.Retrieve(AuthorFirstName, AuthorLastName);
                else
                {
                    author = authorRepository.Create().Initialize(AuthorFirstName, AuthorLastName);
                    authorRepository.Save(author);
                }

                if (author == null || (author != null && author.Id == Guid.Empty))
                    throw new Exception("Nie został zainicjalizowany autor.");

                book.New(BookName, author.Id, rate);
                bookRepository.Save(book);
                MessageBox.Show("Pomyślnie dodano książkę!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Podczas dodawania książki wystąpił błąd. {ex.Message}");
            }
        }
        private bool Validate()
        {
            bool succeed = true;
            string errorMessage = string.Empty;
            if (string.IsNullOrEmpty(BookName))
            {
                errorMessage += $"Nazwa ksiązki musi być podana!" + Environment.NewLine;
                succeed = false;
            }
            if (IsNewAuthor && string.IsNullOrEmpty(AuthorFirstName))
            {
                errorMessage += $"Imię autora musi zostać podane!" + Environment.NewLine;
                succeed = false;
            }
            if (IsNewAuthor && string.IsNullOrEmpty(AuthorLastName))
            {
                errorMessage += $"Nazwisko autora musi zostać podane!" + Environment.NewLine;
                succeed = false;
            }
            if (succeed && !string.IsNullOrEmpty(BookName) && bookRepository.IsExists(BookName))
            {
                errorMessage += $"Istnieje już taka książka [{BookName}] w bazie!" + Environment.NewLine;
                succeed = false;
            }

            if (!string.IsNullOrEmpty(errorMessage))
                MessageBox.Show(errorMessage);

            return succeed;
        }
        public void OnRadioAuthorExistenceClick(RadioAuthorClickEvent args)
        {
            switch (args.AuthorExistence)
            {
                case AuthorExistence.New:
                    IsNewAuthor = true;
                    IsExistingAuthor = false;
                    break;
                case AuthorExistence.Exists:
                    IsNewAuthor = false;
                    IsExistingAuthor = true;
                    break;
            }
        }
        public void OnComboboxValueChanged(object sender)
        {
            if (sender == null)
                return;
            if (sender is not ComboBox comboBox)
                return;

            var value = comboBox.SelectedValue as string;
            if (string.IsNullOrEmpty(value))
                return;

            var splitted = value.Split(' ');
            var author = authors.FirstOrDefault(x => x.FirstName.Equals(splitted[1]) && x.LastName.Equals(splitted[0]));

            if (author == null)
                return;

            AuthorFirstName = author.FirstName;
            AuthorLastName = author.LastName;
        }

        #region NotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
