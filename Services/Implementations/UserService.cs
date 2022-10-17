using React_.Net_App.Models;
using React_.Net_App.Services.Interfaces;

namespace React_.Net_App.Services.Implementations
{
    public class UserService : IUserService
    {
        private ReactCrudDbContext _dbContext;

        public UserService(ReactCrudDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public User CreateUser(User user)
        {
            if (_dbContext.Users.Any(x => x.Email == user.Email)) throw new ApplicationException("An" +
                " Account already exists with this email");

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return user;
        }

        public User GetUserById(int Id)
        {
            var user = _dbContext.Users.Where(x => x.Id == Id).FirstOrDefault();
            if (user == null)
            {
                return null;
            }
            else
            {
                return user;
            }
        }

        public IEnumerable<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }
    }
}
