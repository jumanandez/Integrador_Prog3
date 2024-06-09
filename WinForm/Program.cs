using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Proyecto.Core.Business;
using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Data.Interfaces;
using Proyecto.Core.Data;
using Proyecto.Core.Configurations;
using System;

namespace WinForm
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var formprd = serviceProvider.GetRequiredService<FormProducto>();
                Application.Run(formprd);

            }
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            var connectionString = Properties.Settings.Default.Connection;

            //Se setea la connectionstring en nuestra clase de configuracion
            var config = new Config()
            {
                ConnectionString = connectionString
            };

            


            ServiceProvider serviceProvider = services.BuildServiceProvider();
            services.AddLogging(configure => configure.AddConsole())
                    .AddScoped<Config>(p =>
                    {
                        return config;
                    })
                    .AddScoped<ICatergoriaBusiness, CategoriaBusiness>()
                    .AddScoped<IProjectRepository, ProjectRepository>()
                    .AddScoped<IProductoBusiness, ProductoBusiness>()
                    .AddTransient<FormProducto>()
                    .AddTransient<Form2>();
        }
    }
}