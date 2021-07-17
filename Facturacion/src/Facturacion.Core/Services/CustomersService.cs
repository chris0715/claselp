using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Facturacion.Core.Entities;

namespace Facturacion.Core.Services
{
 
    public class CustomersService
    {
        private readonly AuthService _authService;
        private readonly DbService _dbService;

        public List<FieldInfoCore> FieldDropdowns = new List<FieldInfoCore>() {

            new FieldInfoCore { Label= "Razon Social", DbColumnName = "FullName" },
            new FieldInfoCore { Label= "Cedula", DbColumnName = "GvmtId" },
            new FieldInfoCore { Label= "Cuenta Contable", DbColumnName = "Cuenta" },
        };

        public async Task<bool> CreateCustomer(Customer customer)
        {
            using var db = _dbService.Open();
            var sql = @"INSERT INTO Customers
                          (FullName, GvmtId, Active, CreatedBy, ModifiedBy)
                        VALUES
                          (@FullName, @GvmtId, @Active, @CreatedBy, @ModifiedBy)";

            customer.FullName = customer.FullName.Trim();
            customer.CreatedBy = _authService.CurrentUser.Id;
            customer.ModifiedBy = _authService.CurrentUser.Id;
            try { return (await db.ExecuteAsync(sql, customer)) == 1; } catch { return false; }
        }

        public async Task<IEnumerable<Customer>> GetCustomers(string fullName = null, string gvmtId = null)
        {
            var sql = "SELECT * FROM Customers";
            if (!string.IsNullOrEmpty(fullName) || !string.IsNullOrEmpty(gvmtId))
                sql += " WHERE ";
            if (!string.IsNullOrEmpty(fullName))
                sql += "FullName LIKE '%' || @fullName || '%'";
            if (!string.IsNullOrEmpty(gvmtId))
                sql += $"{(!string.IsNullOrEmpty(fullName)? " AND " : string.Empty)} GvmtId = @gvmtId";

            using var db = _dbService.Open();
            return await db.QueryAsync<Customer>(sql, new { fullName, gvmtId });
        }

        public async Task<Customer> GetCustomer(int id)
        {
            using var db = _dbService.Open();
            var sql = "SELECT * FROM Customers WHERE Id = @id";
            return await db.QueryFirstOrDefaultAsync<Customer>(sql, new { id });
        }

        public async Task<bool> UpdateCustomer(Customer customer)
        {
            customer.ModifiedBy = _authService.CurrentUser.Id;
            using var db = _dbService.Open();
            var sql = @"UPDATE Customers SET 
                            FullName = @FullName, 
                            GvmtId = @GvmtId, 
                            Active = @Active,
                            ModifiedBy = @ModifiedBy,
                            ModifiedOn = date('now')
                        WHERE Id = @Id";
            try { return (await db.ExecuteAsync(sql, customer)) == 1; } catch { return false; }
        }

        public async Task<bool> DeleteCustomer(int id)
        {
            using var db = _dbService.Open();
            return (await db.ExecuteAsync("DELETE FROM Customers WHERE Id = @id", new { id })) == 1;
        }

        public CustomersService(DbService dbService, AuthService authService) =>
            (_dbService, _authService) = (dbService, authService);

        public List<Customer> GetCustomerBy(string fieldDb, object value)
        {

            using var db = _dbService.Open();

            if(!FieldDropdowns.Any(p => p.DbColumnName.EqualIgnoreCase(fieldDb)))
                throw new System.Exception("NOT VALID FIELD");

            var customers = db.Query<Customer>(@$"SELECT * 
                     FROM Customers
                     WHERE {fieldDb} LIKE @n", new { n =  $@"%{value.ToString()}%" })
                    .ToList();
            return customers;
           
        }
    }
}
