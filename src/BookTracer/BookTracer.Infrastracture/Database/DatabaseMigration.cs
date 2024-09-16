using BookTracer.Domain.Domains;
using BookTracer.Infrastracture.Sql.Commands;
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
            string createAuthors = Commands.CreateTableAuthors;
            string createBooks = Commands.CreateTableBooks;

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
