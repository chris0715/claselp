using System;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Facturacion.Core.Services;
using Facturacion.Forms.Views;

namespace Facturacion.Forms
{
    static class Program
    {
        private static readonly IServiceProvider _serviceProvider;

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _serviceProvider.GetService<MigrationsService>().MigrateToLatest();
            Application.Run(_serviceProvider.GetService<MainForm>());
        }

        #region Dependency Injection
        private static void ConfigureServices(IServiceCollection services) =>
            services.AddSingleton<DbService>()
                    .AddSingleton<MigrationsService>()
                    .AddSingleton<AuthService>()
                    .AddSingleton<UsersService>()
                    .AddSingleton<CustomersService>()
                    .AddSingleton<ItemsService>()
                    .AddSingleton<LoginForm>()
                    .AddSingleton<ArticulosListForm>()
                    .AddSingleton<ClientesListForm>()
                    .AddSingleton<FacturasListForm>()
                    .AddSingleton<UsuariosListForm>()
                    .AddSingleton<SellerService>()
                    .AddSingleton<VendedorForm>()
                    .AddSingleton<VendedoresListForm>()
                    .AddSingleton<MainForm>();

        static Program()
        {
            var serviceCollection = new ServiceCollection();
            var configuration = new ConfigurationBuilder()
                              .SetBasePath(AppContext.BaseDirectory).AddJsonFile("appsettings.json")
                              .Build();
            serviceCollection.AddSingleton<IConfiguration>(configuration);
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }
        #endregion
    }
}
