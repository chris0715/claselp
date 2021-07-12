using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using Facturacion.Core.Entities;

namespace Facturacion.Core.Services
{
    public class ItemsService
    {
        private readonly DbService _dbService;
        private readonly AuthService _authService;

        public async Task<bool> CreateItem(Item item)
        {
            using var db = _dbService.Open();
            var sql = @"INSERT INTO Items
                          (Description, Cost, Price, Stock, Active, CreatedBy, ModifiedBy)
                        VALUES
                          (@Description, @Cost, @Price, @Stock, @Active, @CreatedBy, @ModifiedBy)";

            item.Description = item.Description.Trim();
            item.CreatedBy = _authService.CurrentUser.Id;
            item.ModifiedBy = _authService.CurrentUser.Id;
            try { return (await db.ExecuteAsync(sql, item)) == 1; } catch { return false; }
        }

        public async Task<IEnumerable<Item>> GetItems(string description = null)
        {
            var sql = "SELECT * FROM Items";
            if (!string.IsNullOrEmpty(description))
                sql += " WHERE Description LIKE '%' || @description || '%'";

            using var db = _dbService.Open();
            return await db.QueryAsync<Item>(sql, new { description = description.Trim() });
        }

        public async Task<Item> GetItem(int id)
        {
            using var db = _dbService.Open();
            var sql = "SELECT * FROM Items WHERE Id = @id";
            return await db.QueryFirstOrDefaultAsync<Item>(sql, new { id });
        }

        public async Task<bool> UpdateItem(Item item)
        {
            item.ModifiedBy = _authService.CurrentUser.Id;
            using var db = _dbService.Open();
            var sql = @"UPDATE Items SET 
                            Description = @Description,  
                            Active = @Active,
                            Cost = @Cost,
                            Price = @Price,
                            Stock = @Stock,
                            ModifiedBy = @ModifiedBy,
                            ModifiedOn = date('now')
                        WHERE Id = @Id";
            try { return (await db.ExecuteAsync(sql, item)) == 1; } catch { return false; }
        }

        public async Task<bool> DeleteItem(int id)
        {
            using var db = _dbService.Open();
            return (await db.ExecuteAsync("DELETE FROM Items WHERE Id = @id", new { id })) == 1;
        }

        public ItemsService(AuthService authService, DbService dbService) =>
            (_dbService, _authService) = (dbService, authService);
    }
}
