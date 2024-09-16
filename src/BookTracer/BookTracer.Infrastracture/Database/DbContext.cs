using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracer.Infrastracture.Database
{
    public class DbContext : IDbContext
    {
        private const string DatabaseName = "BookTracer";
        public SqliteConnection RetrieveConnection()
        {
            SQLitePCL.Batteries.Init();
            return new SqliteConnection($"Data source={DatabaseName}"); ;
        }
        public SqliteCommand RetrieveCommand(string sql, SqliteConnection connection)
            => new SqliteCommand(sql, connection);
    }

    public interface IDbContext
    {
        SqliteCommand RetrieveCommand(string sql, SqliteConnection connection);
        SqliteConnection RetrieveConnection();
    }
}
