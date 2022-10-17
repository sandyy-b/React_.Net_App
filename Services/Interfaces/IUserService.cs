using React_.Net_App.Models;

namespace React_.Net_App.Services.Interfaces
{
    public interface IUserService
    {
        User CreateUser(User user);
        IEnumerable<User> GetUsers();
        User GetUserById(int Id);
    }
}
