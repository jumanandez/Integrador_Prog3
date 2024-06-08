using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Proyecto.Core.Business;
using Proyecto.Core.Business.Interfaces;

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
                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddLogging(configure => configure.AddConsole())
                    .AddScoped<ICatergoriaBusiness, CategoriaBusiness>()
                    .AddScoped<IProductoBusiness, ProductoBusiness>()
                    .AddTransient<Form1>();
        }
    }
}