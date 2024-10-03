using BookTracer.Controls;
using BookTracer.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracer
{
    public static class Bootstrapper
    {
        public static ServiceCollection RegisterUI(this ServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.RegisterControls();
            services.RegisterServices();

            return services;
        }
        private static ServiceCollection RegisterControls(this ServiceCollection services)
        {
            services.AddScoped<FormMain>();
            services.AddTransient<ControlAddBook>();
            services.AddTransient<ControlImport>();

            return services;
        }
        private static ServiceCollection RegisterServices(this ServiceCollection services)
        {
            services.AddTransient(typeof(IImportService), typeof(ImportService));

            return services;
        }
    }
}
