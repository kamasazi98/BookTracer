using Microsoft.Extensions.DependencyInjection;
using BookTracer.Infrastracture;
using BookTracer.Infrastracture.Database;
using BookTracer.Controls;
namespace BookTracer
{
    internal static class Program
    {
        private static IServiceProvider serviceProvider;
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();

            var databaseMigration = serviceProvider.GetService(typeof(IDatabaseMigration)) as IDatabaseMigration;
            if (databaseMigration == null)
                throw new ArgumentNullException(nameof(databaseMigration));
            Migrations(databaseMigration);

            var mainForm = serviceProvider.GetRequiredService<FormMain>();
            Application.Run(mainForm);
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.RegisterDatabaseContext();
            services.RegisterRepositories();

            services.AddScoped<FormMain>();
            services.AddTransient<ControlAddBook>();
        }
        private static void Migrations(IDatabaseMigration databaseMigration)
        {
            databaseMigration.Migration_001();
        }
    }
}