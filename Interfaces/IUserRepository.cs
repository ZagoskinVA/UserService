using System.Linq.Expressions;
using UserService.Models;

namespace UserService.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers(Func<Profile, bool> predicate);
    }
}
