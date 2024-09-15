using BookTracer.Domain.Repositories;
using BookTracer.Infrastracture.Database;
using BookTracer.Infrastracture.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracer.Infrastracture
{
    public static class Bootstrapper
    {
        public static ServiceCollection RegisterRepositories(this ServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddScoped(typeof(IAuthorRepository), typeof(AuthorRepository));
            services.AddScoped(typeof(IBookRepository), typeof(BookRepository));

            return services;
        }
        public static ServiceCollection RegisterDatabaseContext(this ServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddSingleton(typeof(IDbContext), typeof(DbContext));
            services.AddSingleton(typeof(IDatabaseMigration), typeof(DatabaseMigration));

            return services;
        }
    }
}
