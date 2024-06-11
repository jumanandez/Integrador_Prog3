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
            var connectionString = "Persist Security Info=True;Initial Catalog=IntegradorProg3;Data Source=.; Application Name=DemoApp; Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;";

            //Se setea la connectionstring en nuestra clase de configuracion
            var config = new Proyecto.Core.Configurations.Config()
            {
                ConnectionString = connectionString
            };

            var projectgay = new ProjectRepository(config);


            ServiceProvider serviceProvider = services.BuildServiceProvider();
            services.AddLogging(configure => configure.AddConsole())
                    .AddScoped<Config>(p =>
                    {
                        return config;
                    })
                    .AddScoped<ICategoriaBusiness, CategoriaBusiness>()
                    .AddScoped<IProjectRepository, ProjectRepository>()
                    .AddScoped<IProductoBusiness, ProductoBusiness>()
                    .AddTransient<FormProducto>();
        }
    }
}