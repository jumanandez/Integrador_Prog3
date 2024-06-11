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
            //using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            //{

            //    var login = serviceProvider.GetRequiredService<FormLogin>();
            //    Application.Run(login);

            //}

			using (ServiceProvider serviceProvider = services.BuildServiceProvider())
			{
				// Fetch the login form from the service provider
				var login = serviceProvider.GetRequiredService<FormLogin>();

				// Display the login form and handle the result
				if (login.ShowDialog() == DialogResult.OK)
				{
					// Create necessary instances based on successful login

					var formProducto = serviceProvider.GetRequiredService<FormProducto>();

					// Set logged user if available (optional)
					if (login.User != null)
					{
						formProducto._loggedUser = login.User;
                    }

                    // Launch the main application (FormProducto)
                    Application.Run(formProducto);
                }
                else
				{
					// Handle failed login (optional)
					MessageBox.Show("Fallo al iniciar. La aplicacion se cerrará");
					Application.Exit();
				}
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
                    .AddScoped<ICategoriaBusiness, CategoriaBusiness>()
                    .AddScoped<IProjectRepository, ProjectRepository>()
                    .AddScoped<IProductoBusiness, ProductoBusiness>()
                    .AddScoped<IUsuarioBusiness, UsuarioBusiness>()
                    .AddTransient<FormProducto>()
                    .AddTransient<Form2>()
                    .AddTransient<FormLogin>();

            //ServiceProvider serviceLogin = services.BuildServiceProvider();
            //services.AddLogging(configure => configure.AddConsole())
            //        .AddScoped<Config>(p =>
            //        {
            //            return config;
            //        })
            //        .AddScoped<IUsuarioBusiness, UsuarioBusiness>()
            //        .AddScoped<IProjectRepository, ProjectRepository>()
            //        .AddTransient<FormLogin>();

        }
    }
}