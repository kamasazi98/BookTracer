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

namespace BookTracer.Infrastracture.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly IDbContext dbContext;
        private readonly IServiceProvider serviceProvider;

        public AuthorRepository(IDbContext dbContext
            , IServiceProvider serviceProvider)
        {
            this.dbContext = dbContext;
            this.serviceProvider = serviceProvider;
        }
        public List<IAuthor> RetrieveAll()
        {
            List<IAuthor> destiantion = new List<IAuthor>();

            string query = Queries.RetrieveAllAuthors;
            using var connection = dbContext.RetrieveConnection();
            connection.Open();
            using var command = dbContext.RetrieveCommand(query, connection);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                destiantion.Add(new Author(serviceProvider.GetRequiredService<IBookRepository>())
                    .Load(
                        reader.GetString(reader.GetOrdinal("Id")),
                        reader.GetString(reader.GetOrdinal("FirstName")),
                        reader.GetString(reader.GetOrdinal("LastName"))
                    ));
            }
            return destiantion;
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
                author = new Author(serviceProvider.GetRequiredService<IBookRepository>())
                    .Load(
                        reader.GetString(reader.GetOrdinal("Id")),
                        reader.GetString(reader.GetOrdinal("FirstName")),
                        reader.GetString(reader.GetOrdinal("LastName"))
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
            command.Parameters.AddWithValue("@Id", id.ToString());

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                author = new Author(serviceProvider.GetRequiredService<IBookRepository>())
                    .Load(
                        reader.GetString(reader.GetOrdinal("Id")),
                        reader.GetString(reader.GetOrdinal("FirstName")),
                        reader.GetString(reader.GetOrdinal("LastName"))
                    );
            }
            return author;
        }
        public Author Create()
            => new Author(serviceProvider.GetRequiredService<IBookRepository>());
        public void Save(IAuthor author)
        {
            string commandSql = string.Empty;
            using var connection = dbContext.RetrieveConnection();
            connection.Open();

            if (author.Id == Guid.Empty)
            {
                commandSql = Commands.InsertAuthor;
                author.SetId(Guid.NewGuid());
            }
            else
                commandSql = Commands.UpdateAuthor;

            using var command = dbContext.RetrieveCommand(commandSql, connection);
            command.Parameters.AddWithValue("@Id", author.Id.ToString());
            command.Parameters.AddWithValue("@FirstName", author.FirstName);
            command.Parameters.AddWithValue("@LastName", author.LastName);
            command.ExecuteNonQuery();
        }
    }
}
