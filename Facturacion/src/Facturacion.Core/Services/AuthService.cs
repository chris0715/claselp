using System;
using System.Threading.Tasks;
using Dapper;
using Facturacion.Core.Entities;

namespace Facturacion.Core.Services
{
    public class AuthService
    {
        private readonly DbService _dbService;

        public User CurrentUser { get; private set; }

        private async Task<User> FindUserByUsername(string username)
        {
            using var db = _dbService.Open();

            var sql = "SELECT * FROM Users WHERE Username = @username";
            return await db.QueryFirstOrDefaultAsync<User>(sql, new 
            { 
                username = username.ToLower() 
            });
        }

        public async Task<LoginResult> Login(string username, string password)
        {
            var user = await FindUserByUsername(username);

            if (user is null)
                return LoginResult.InvalidUsername;

            if (!user.Password.Equals(password, StringComparison.Ordinal))
                return LoginResult.InvalidPassword;

            if (!user.Active)
                return LoginResult.InactiveUser;

            CurrentUser = user;
            return LoginResult.Success;
        }

        public void Logout() => CurrentUser = null;

        public AuthService(DbService dbService) =>
            _dbService = dbService;
    }
}
