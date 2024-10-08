using BookTracer.Domain.Domains;
using BookTracer.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        }
        public AuthorListViewModel Initialize()
        {
            AuthorsDataSource.Clear();
            int no = 1;
            foreach (var author in authorRepository.RetrieveAll())
                AuthorsDataSource.Add(new AuthorListElementViewModel(author, no));

            return this;
        }
        public BindingList<AuthorListElementViewModel> AuthorsDataSource { get; set; }
        public BindingList<BookElementViewModel> AuthorBooksDataSource { get; set; }
        public void FocusedAuthorChanged(Guid authorId)
        {
            AuthorBooksDataSource.Clear();
            var author = AuthorsDataSource.FirstOrDefault(x => x.Id.Equals(authorId));
            if (author == null)
                return;

            int no = 1;
            foreach (var book in author.Domain.Books)
                AuthorBooksDataSource.Add(new BookElementViewModel(book, no));
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
