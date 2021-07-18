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

        //public async Task<IEnumerable<Customer>> GetCustomers(string fullName = null, string gvmtId = null)
        //{
        //    var sql = "SELECT * FROM Customers";
        //    if (!string.IsNullOrEmpty(fullName) || !string.IsNullOrEmpty(gvmtId))
        //        sql += " WHERE ";
        //    if (!string.IsNullOrEmpty(fullName))
        //        sql += "FullName LIKE '%' || @fullName || '%'";
        //    if (!string.IsNullOrEmpty(gvmtId))
        //        sql += $"{(!string.IsNullOrEmpty(fullName)? " AND " : string.Empty)} GvmtId = @gvmtId";

        //    using var db = _dbService.Open();
        //    return await db.QueryAsync<Customer>(sql, new { fullName, gvmtId });
        //}

        public IEnumerable<Customer> GetCustomers(string fieldDb = null, string value = null)
        {
            var sql = "SELECT * FROM Customers";
            using var db = _dbService.Open();
            if (!string.IsNullOrEmpty(fieldDb) && !value.IsBlank())
            {
                sql += $" WHERE {fieldDb} LIKE  @param1";
                return db.Query<Customer>(sql, new { param1 = $"%{value.Trim()}%" }).ToList();
            }
            else if (!value.IsBlank())
            {
                sql += $" WHERE FullName LIKE  @param1";
            }
            return db.Query<Customer>(sql).ToList();
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



        public static bool ValidarCedula(string cedula)
        {
            int digito = 0;
            int digitoVerificador = 0;
            bool resultado = false;
            int[] multiplicadores = { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            int producto = 0;
            int suma = 0;

            if (cedula.Contains("-"))
                cedula = cedula.Replace("-", "");

            _ = int.TryParse(cedula.Substring(cedula.Length - 1), out digitoVerificador);

            for (int i = 0; i < (cedula.Length - 1); i++)
            {
                _ = int.TryParse(cedula[i].ToString(), out digito);
                producto = digito * multiplicadores[i];

                if (producto >= 10)
                    producto = (producto / 10) + (producto % 10);

                suma += producto;
            }

            if ((suma + digitoVerificador) % 10 == 0)
                resultado = true;

            return resultado;
        }
    }
}
