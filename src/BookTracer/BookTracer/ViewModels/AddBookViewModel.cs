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
    public class AddBookViewModel : INotifyPropertyChanged
    {
        #region Properties
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
                    break;
                case RateBox.Second:
                    SecondRate = !SecondRate;
                    pictureBoxName = "pictureBoxSecondStar";
                    break;
                case RateBox.Third:
                    ThirdRate = !ThirdRate;
                    pictureBoxName = "pictureBoxThridStar";
                    break;
                case RateBox.Fourth:
                    FourthRate = !FourthRate;
                    pictureBoxName = "pictureBoxFourthStar";
                    break;
                case RateBox.Fifth:
                    FifthRate = !FifthRate;
                    pictureBoxName = "pictureBoxFifthStar";
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
        #region NotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
