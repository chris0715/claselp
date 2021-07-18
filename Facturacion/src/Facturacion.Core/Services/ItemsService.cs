﻿using System;
using System.Collections.Generic;
using System.Linq;
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



        public IEnumerable<Item> GetItems(string fieldDb = null, string value = null)
        {
            var sql = "SELECT * FROM Items";
            using var db = _dbService.Open();
            if (!string.IsNullOrEmpty(fieldDb) && !value.IsBlank())
            {
                sql += $" WHERE {fieldDb} LIKE  @param1";
                return db.Query<Item>(sql, new { param1 = $"%{value.Trim()}%" }).ToList();
            }
            else if (!value.IsBlank())
            {
                sql += $" WHERE Description LIKE  @param1";
            }
            return db.Query<Item>(sql).ToList();
            
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
