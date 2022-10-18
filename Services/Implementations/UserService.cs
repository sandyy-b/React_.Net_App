using React_.Net_App.Models;
using React_.Net_App.Services.Interfaces;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace React_.Net_App.Services.Implementations
{
    public class UserService : IUserService
    {
        private ReactCrudDbContext _dbContext;

        public UserService(ReactCrudDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<User> GetUsers(string queryText)
        {
            var users = _dbContext.Users.FromSqlRaw($"{queryText}").ToList();
            return users;
        }
    }
}