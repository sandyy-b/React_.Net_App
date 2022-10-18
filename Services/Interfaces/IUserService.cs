using React_.Net_App.Models;

namespace React_.Net_App.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers(string queryText);  
    }
}
