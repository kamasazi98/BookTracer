using BookTracer.Domain.Domains;
using BookTracer.Domain.Repositories;
using BookTracer.Infrastracture.Database;
using BookTracer.Infrastracture.Sql.Commands;
using BookTracer.Infrastracture.Sql.Queries;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookTracer.Infrastracture.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IDbContext dbContext;
        private readonly IServiceProvider serviceProvider;

        public BookRepository(IDbContext dbContext
            , IServiceProvider serviceProvider)
        {
            this.dbContext = dbContext;
            this.serviceProvider = serviceProvider;
        }
        public List<Book> Retrieve(Guid authorId)
        {
            List<Book> destiantion = new List<Book>();
            string query = Queries.RetrieveBookAuthorId;
            using var connection = dbContext.RetrieveConnection();
            connection.Open();

            using var command = dbContext.RetrieveCommand(query, connection);
            command.Parameters.AddWithValue("@AuthorId", authorId.ToString());

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                destiantion.Add(new Book(serviceProvider.GetRequiredService<IAuthorRepository>())
                    .Load(
                        reader.GetString(reader.GetOrdinal("Id")),
                        reader.GetString(reader.GetOrdinal("Name")),
                        reader.GetString(reader.GetOrdinal("AuthorId")),
                        reader.GetInt32(reader.GetOrdinal("Rate"))
                    ));
            }
            return destiantion;
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
                book = new Book(serviceProvider.GetRequiredService<IAuthorRepository>())
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
            => new Book(serviceProvider.GetRequiredService<IAuthorRepository>());
        public List<Book> RetrieveAll()
        {
            List<Book> destiantion = new List<Book>();
            string query = Queries.RetrieveAllBooks;
            using var connection = dbContext.RetrieveConnection();
            connection.Open();

            using var command = dbContext.RetrieveCommand(query, connection);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                destiantion.Add(new Book(serviceProvider.GetRequiredService<IAuthorRepository>())
                    .Load(
                        reader.GetString(reader.GetOrdinal("Id")),
                        reader.GetString(reader.GetOrdinal("Name")),
                        reader.GetString(reader.GetOrdinal("AuthorId")),
                        reader.GetInt32(reader.GetOrdinal("Rate"))
                    ));
            }
            return destiantion;
        }
        public void Save(Book book)
        {
            string commandSql = string.Empty;
            using var connection = dbContext.RetrieveConnection();
            connection.Open();

            if (book.Id == Guid.Empty)
            {
                commandSql = Commands.InsertBook;
                book.SetId(Guid.NewGuid());
            }
            else
                commandSql = Commands.UpdateBook;

            using var command = dbContext.RetrieveCommand(commandSql, connection);
            command.Parameters.AddWithValue("@Id", book.Id.ToString());
            command.Parameters.AddWithValue("@Name", book.Name);
            command.Parameters.AddWithValue("@AuthorId", book.AuthorId.ToString());
            command.Parameters.AddWithValue("@Rate", book.Rate);
            command.ExecuteNonQuery();
        }
    }
}
