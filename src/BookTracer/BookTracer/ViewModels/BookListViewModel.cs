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
    public class BookListViewModel : IDisposable
    {
        private readonly IBookRepository bookRepository;

        public BookListViewModel(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
            BooksDataSource = new List<BookListElementViewModel>();
            BooksDataTable = new DataTable();
        }
        public BookListViewModel Initialize()
        {
            int no = 1;
            BooksDataTable.Columns.Add(nameof(BookListElementViewModel.No), typeof(int));
            BooksDataTable.Columns.Add(nameof(BookListElementViewModel.BookName), typeof(string));
            BooksDataTable.Columns.Add(nameof(BookListElementViewModel.BookRating), typeof(int));
            BooksDataTable.Columns.Add(nameof(BookListElementViewModel.AuthorFirstName), typeof(string));
            BooksDataTable.Columns.Add(nameof(BookListElementViewModel.AuthorLastName), typeof(string));

            foreach (var book in bookRepository.RetrieveAll())
            {
                var element = new BookListElementViewModel(book, no++);
                BooksDataTable.Rows.Add(element.No, element.BookName, element.BookRating, element.AuthorFirstName, element.AuthorLastName);
                BooksDataSource.Add(element);
            }

            return this;
        }
        public DataTable BooksDataTable { get; private set; }
        public List<BookListElementViewModel> BooksDataSource { get; set; }

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
        public string AuthorFirstName => Domain?.Author?.FirstName ?? string.Empty;
        public string AuthorLastName => Domain?.Author?.LastName ?? string.Empty;
    }
}
