using BookTracer.Domain.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracer.Infrastracture.Database
{
    public class DatabaseMigration : IDatabaseMigration
    {
        private readonly IDbContext dbContext;

        public DatabaseMigration(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Migration_001()
        {
            using var connection = dbContext.RetrieveConnection();
            connection.Open();
            string createAuthors = "CREATE TABLE IF NOT EXISTS Authors (" + Environment.NewLine;
            createAuthors += $"{nameof(IAuthor.Id)} TEXT PRIMARY KEY," + Environment.NewLine;
            createAuthors += $"{nameof(IAuthor.FirstName)} TEXT NOT NULL," + Environment.NewLine;
            createAuthors += $"{nameof(IAuthor.LastName)} TEXT NOT NULL" + Environment.NewLine;
            createAuthors += $");" + Environment.NewLine;

            string createBooks = "CREATE TABLE IF NOT EXISTS Books (" + Environment.NewLine;
            createBooks += $"{nameof(IBook.Id)} TEXT PRIMARY KEY," + Environment.NewLine;
            createBooks += $"{nameof(IBook.Name)} TEXT NOT NULL," + Environment.NewLine;
            createBooks += $"{nameof(IBook.AuthorId)} TEXT NOT NULL," + Environment.NewLine;
            createBooks += $"FOREIGN KEY ({nameof(IBook.AuthorId)}) REFERENCES Authors({nameof(IAuthor.Id)}) ON DELETE CASCADE" + Environment.NewLine;
            createAuthors += $");" + Environment.NewLine;

            using var commandCreateAuthors = dbContext.RetrieveCommand(createAuthors, connection);
            commandCreateAuthors.ExecuteNonQuery();

            using var commandCreateBooks = dbContext.RetrieveCommand(createBooks, connection);
            commandCreateBooks.ExecuteNonQuery();

            connection.Close();
        }
    }

    public interface IDatabaseMigration
    {
        void Migration_001();
    }
}
