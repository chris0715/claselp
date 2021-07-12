using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using Facturacion.Core.Entities;

namespace Facturacion.Core.Services
{
    public class UsersService
    {
        private readonly AuthService _authService;
        private readonly DbService _dbService;

        public async Task<bool> CreateUser(User user)
        {
            using var db = _dbService.Open();
            var sql = @"INSERT INTO Users
                          (Username, Password, Active, CreatedBy, ModifiedBy)
                        VALUES
                          (@Username, @Password, @Active, @CreatedBy, @ModifiedBy)";

            user.Username = user.Username.Trim().ToLower();
            user.CreatedBy = _authService.CurrentUser.Id;
            user.ModifiedBy = _authService.CurrentUser.Id;
            try { return (await db.ExecuteAsync(sql, user)) == 1; } catch { return false; }
        }


        public async Task<IEnumerable<User>> GetUsers(string username = null, bool? status = null)
        {
            var sql = "SELECT * FROM Users";
            if (username is object || status is object)
                sql += " WHERE ";
            if (username is object)
                sql += "Username LIKE '%' || @username || '%'";
            if (status is bool? && status.HasValue)
                sql += $"{(username is object? " AND ": string.Empty)} Active = @status";

            using var db = _dbService.Open();
            return await db.QueryAsync<User>(sql, new { username, status });
        }

        public async Task<User> GetUser(int id)
        {
            using var db = _dbService.Open();
            var sql = "SELECT * FROM Users WHERE Id = @id";
            return await db.QueryFirstOrDefaultAsync<User>(sql, new { id });
        }

        public async Task<bool> UpdateUser(User user)
        {
            user.ModifiedBy = _authService.CurrentUser.Id;
            using var db = _dbService.Open();
            var sql = @"UPDATE Users SET 
                            Username = @Username, 
                            Password = @Password, 
                            Active = @Active,
                            ModifiedBy = @ModifiedBy,
                            ModifiedOn = date('now')
                        WHERE Id = @Id";
            try { return (await db.ExecuteAsync(sql, user)) == 1; } catch { return false; }
        }

        public async Task<bool> DeleteUser(int id)
        {
            using var db = _dbService.Open();
            return (await db.ExecuteAsync("DELETE FROM Users WHERE Id = @id", new { id })) == 1;
        }

        public UsersService(DbService dbService, AuthService authService) =>
            (_dbService, _authService) = (dbService, authService);
    }
}
