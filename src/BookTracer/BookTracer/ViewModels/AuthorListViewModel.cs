using BookTracer.Domain.Domains;
using BookTracer.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracer.ViewModels
{
    public class AuthorListViewModel : IDisposable
    {
        private readonly IAuthorRepository authorRepository;

        public AuthorListViewModel(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
            AuthorsDataSource = new BindingList<AuthorListElementViewModel>();
            AuthorBooksDataSource = new BindingList<BookElementViewModel>();
            AuthorsDataTable = new DataTable();
        }
        public AuthorListViewModel Initialize()
        {
            AuthorsDataSource.Clear();
            int no = 1;

            AuthorsDataTable.Columns.Add(nameof(AuthorListElementViewModel.No), typeof(int));
            AuthorsDataTable.Columns.Add(nameof(AuthorListElementViewModel.Id), typeof(Guid));
            AuthorsDataTable.Columns.Add(nameof(AuthorListElementViewModel.FirstName), typeof(string));
            AuthorsDataTable.Columns.Add(nameof(AuthorListElementViewModel.LastName), typeof(string));

            foreach (var author in authorRepository.RetrieveAll())
            {
                var element = new AuthorListElementViewModel(author, no++);
                AuthorsDataTable.Rows.Add(element.No, element.Id, element.FirstName, element.LastName);
                AuthorsDataSource.Add(element);
            }

            return this;
        }
        public DataTable AuthorsDataTable { get; private set; }
        public BindingList<AuthorListElementViewModel> AuthorsDataSource { get; set; }
        public BindingList<BookElementViewModel> AuthorBooksDataSource { get; set; }
        public void FocusedAuthorChanged(Guid authorId)
        {
            AuthorBooksDataSource.Clear();
            var author = AuthorsDataSource.FirstOrDefault(x => x.Id.Equals(authorId));
            if (author == null)
                return;

            int no = 1;
            foreach (var book in author.Domain.Books.OrderBy(x=>x.Name))
                AuthorBooksDataSource.Add(new BookElementViewModel(book, no++));
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
    public class AuthorListElementViewModel
    {
        public AuthorListElementViewModel(IAuthor author, int no)
        {
            Domain = author;
            No = no;
        }

        public IAuthor Domain { get; }
        public int No { get; }
        public Guid Id => Domain.Id;
        public string FirstName => Domain.FirstName;
        public string LastName => Domain.LastName;
    }
    public class BookElementViewModel
    {
        public BookElementViewModel(IBook book, int no)
        {
            Domain = book;
            No = no;

        }
        private IBook Domain;
        public int No { get; }
        public string BookName => Domain.Name;
        public int BookRating => Domain.Rate;
    }
}
