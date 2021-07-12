using System;
using System.Data.SQLite;
using Microsoft.Extensions.Configuration;

namespace Facturacion.Core.Services
{
    public class DbService
    {
        private readonly string _connectionString;

        public SQLiteConnection Open() => new SQLiteConnection(_connectionString);

        public DbService(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("FacturacionDb");

            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("Connection string is either null or empty.");

            _connectionString = connectionString;
        }
    }
}
