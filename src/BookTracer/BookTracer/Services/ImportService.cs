using BookTracer.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracer.Services
{
    public class ImportService : IImportService
    {
        private readonly IAuthorRepository authorRepository;
        private readonly IBookRepository bookRepository;

        public ImportService(IAuthorRepository authorRepository
            , IBookRepository bookRepository)
        {
            this.authorRepository = authorRepository;
            this.bookRepository = bookRepository;
        }
        public void Import(string filePath)
        {
            var data = File.ReadAllLines(filePath)
                .Select(line => line.Split(','))
                .Select(e => new
                {
                    BookName = e[0],
                    AuthorFirstName = e[1],
                    AuthorLastName = e[2],
                    Rate = int.Parse(e[3])
                });

            foreach (var dataRow in data)
            {
                var book = bookRepository.Retrieve(dataRow.BookName);
                if (book != null)
                    continue;

                book = bookRepository.Create();
                var author = authorRepository.Retrieve(dataRow.AuthorFirstName, dataRow.AuthorLastName);
                if (author == null)
                {
                    author = authorRepository.Create().Initialize(dataRow.AuthorFirstName, dataRow.AuthorLastName);
                    authorRepository.Save(author);
                }

                book.New(dataRow.BookName, author.Id, dataRow.Rate);
                bookRepository.Save(book);
            }
        }
    }

    public interface IImportService
    {
        void Import(string filePath);
    }
}
