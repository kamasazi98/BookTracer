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
    public class AuthorRepository : IAuthorRepository
    {
        private readonly IDbContext dbContext;

        public AuthorRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<IAuthor> RetrieveAll()
        {
            return new List<IAuthor>();
        }
        public IAuthor? Retrieve(string firstName, string lastName)
        {
            Author? author = null;
            string query = Queries.RetrieveByFirstNameAndLastName;
            using var connection = dbContext.RetrieveConnection();
            connection.Open();

            using var command = dbContext.RetrieveCommand(query, connection);
            command.Parameters.AddWithValue("@FirstNameValue", firstName);
            command.Parameters.AddWithValue("@LastNameValue", lastName);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                author = new Author()
                    .Load(
                        reader.GetString(reader.GetOrdinal("Id")),
                        reader.GetString(reader.GetOrdinal("FirstName")),
                        reader.GetString(reader.GetOrdinal("LastName")),
                        new List<Book>()
                    );
            }
            return author;
        }
        public IAuthor Retrieve(Guid id)
        {
            Author? author = null;
            string query = Queries.RetrieveByGuid;
            using var connection = dbContext.RetrieveConnection();
            connection.Open();

            using var command = dbContext.RetrieveCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                author = new Author()
                    .Load(
                        reader.GetString(reader.GetOrdinal("Id")),
                        reader.GetString(reader.GetOrdinal("FirstName")),
                        reader.GetString(reader.GetOrdinal("LastName")),
                        new List<Book>()
                    );
            }
            return author;
        }
        public Author Create()
            => new Author();

        public void Save(IAuthor author)
        {
            throw new NotImplementedException();
        }
    }
}
