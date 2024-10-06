using BookTracer.Domain.Domains;
using BookTracer.Domain.Repositories;
using BookTracer.Infrastracture.Database;
using BookTracer.Infrastracture.Sql.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracer.Infrastracture.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IDbContext dbContext;

        public BookRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Book Retrieve(Guid authorId)
        {
            throw new NotImplementedException();
        }
        public Book? Retrieve(string bookName)
        {
            Book? book = null;
            string query = Queries.RetrieveByBookName;
            using var connection = dbContext.RetrieveConnection();
            connection.Open();

            using var command = dbContext.RetrieveCommand(query, connection);
            command.Parameters.AddWithValue("@BookName", bookName);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                book = new Book()
                    .Load(
                        reader.GetString(reader.GetOrdinal("Id")),
                        reader.GetString(reader.GetOrdinal("Name")),
                        reader.GetString(reader.GetOrdinal("AuthorId")),
                        reader.GetInt32(reader.GetOrdinal("Rate"))
                    );
            }
            return book;
        }
        public bool IsExists(string bookName)
        {
            var book = Retrieve(bookName);
            return !(book == null || (book != null && book.Id == Guid.Empty));
        }
        public Book Create()
            => new Book();

        public List<Book> RetrieveAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
