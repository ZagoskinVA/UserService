using UserService.Models;

namespace UserService.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers(Dictionary<string, string> filtersSource);
    }
}
