using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Facturacion.Core.Entities;

namespace Facturacion.Core.Services
{
 
    public class SellerService
    {
        private readonly AuthService _authService;
        private readonly DbService _dbService;


        public async Task<bool> CreateSeller(Seller record)
        {
            using var db = _dbService.Open();
            var sql = @"INSERT INTO Sellers
                          (FullName, Commission, Active, CreatedBy, ModifiedBy)
                        VALUES
                          (@FullName, @Commission, @Active, @CreatedBy, @ModifiedBy)";

            record.FullName = record.FullName.Trim();
            record.CreatedBy = _authService.CurrentUser.Id;
            record.ModifiedBy = _authService.CurrentUser.Id;
            try { return (await db.ExecuteAsync(sql, record)) == 1; } catch { return false; }
        }

        public IEnumerable<Seller> GetSellers(string fieldDb = null, string value = null)
        {

            var sql = "SELECT * FROM Sellers";
            using var db = _dbService.Open();
            if (!string.IsNullOrEmpty(fieldDb) && !value.IsBlank())
            {
                sql += $" WHERE {fieldDb} LIKE  @param1";
                return db.Query<Seller>(sql, new { param1 = $"%{value.Trim()}%" }).ToList();
            }
            else if (!value.IsBlank())
            {
                sql += $" WHERE DefaultField LIKE  @param1";
            }
            return db.Query<Seller>(sql).ToList();
        }

        public async Task<Seller> GetSeller(int id)
        {
            using var db = _dbService.Open();
            var sql = "SELECT * FROM Sellers WHERE Id = @id";
            return await db.QueryFirstOrDefaultAsync<Seller>(sql, new { id });
        }
        /*

          CREATE TABLE Sellers (
               Id           INTEGER PRIMARY KEY AUTOINCREMENT,
               FullName     TEXT            NOT NULL,
               Commission   DOUBLE          NOT NULL,
               Active       TINYINT         NOT NULL DEFAULT (1),
               CreatedBy    INT             NOT NULL,
               CreatedOn    DATETIME        NOT NULL DEFAULT (DATETIME('now')),
               ModifiedBy   INT             NOT NULL,
               ModifiedOn   DATETIME        NOT NULL DEFAULT (DATETIME('now')),
               CONSTRAINT fk_Seller_CreatedBy  FOREIGN KEY (CreatedBy)  REFERENCES Users(CreatedBy),
               CONSTRAINT fk_Seller_ModifiedBy FOREIGN KEY (ModifiedBy) REFERENCES Users(ModifiedBy),
               CONSTRAINT chk_Seller_Commission CHECK (Commission >= 0.00)
           );
*/
        public async Task<bool> UpdateSeller(Seller record)
        {
            record.ModifiedBy = _authService.CurrentUser.Id;
            using var db = _dbService.Open();
            var sql = @"UPDATE Sellers SET 
                            FullName = @FullName, 
                            Commission = @Commission, 
                            Active = @Active,
                            ModifiedBy = @ModifiedBy,
                            ModifiedOn = date('now')
                        WHERE Id = @Id";
            try { return (await db.ExecuteAsync(sql, record)) == 1; } catch { return false; }
        }

        public async Task<bool> DeleteSeller(int id)
        {
            using var db = _dbService.Open();
            return (await db.ExecuteAsync("DELETE FROM Sellers WHERE Id = @id", new { id })) == 1;
        }

        public SellerService(DbService dbService, AuthService authService) =>
            (_dbService, _authService) = (dbService, authService);

    }
}
