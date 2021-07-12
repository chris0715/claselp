using SimpleMigrations;
using SimpleMigrations.DatabaseProvider;
using Facturacion.Migrations;

namespace Facturacion.Core.Services
{
    public class MigrationsService
    {
        private readonly DbService _dbService;

        public void MigrateToLatest()
        {
            var connection = _dbService.Open();
            var assembly = typeof(M001_CreateTables).Assembly;
            var provider = new SqliteDatabaseProvider(connection);
            var migrator = new SimpleMigrator(assembly, provider);

            migrator.Load();
            migrator.MigrateToLatest();
        }

        public MigrationsService(DbService dbService) =>
            _dbService = dbService;
    }
}
