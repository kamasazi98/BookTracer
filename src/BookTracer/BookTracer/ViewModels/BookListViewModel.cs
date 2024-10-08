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
    public class BookListViewModel : IDisposable
    {
        private readonly IBookRepository bookRepository;

        public BookListViewModel(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
            BooksDataSource = new BindingList<BookListElementViewModel>();
        }
        public BookListViewModel Initialize()
        {
            BooksDataSource.Clear();
            int no = 1;
            foreach (var book in bookRepository.RetrieveAll())
                BooksDataSource.Add(new BookListElementViewModel(book, no++));

            return this;
        }
        public BindingList<BookListElementViewModel> BooksDataSource { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
    public class BookListElementViewModel
    {
        public BookListElementViewModel(IBook book, int no)
        {
            Domain = book;
            No = no;

        }
        private IBook Domain;
        public int No { get; }
        public string BookName => Domain.Name;
        public int BookRating => Domain.Rate;
        public string AuthorFirstName => Domain?.Author.FirstName ?? string.Empty;
        public string AuthorLastName => Domain?.Author.LastName ?? string.Empty;
    }
}
