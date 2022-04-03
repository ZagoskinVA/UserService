using System.Linq.Expressions;
using UserService.Models;

namespace UserService.Interfaces
{
    public interface IFilter
    {
        Expression<Func<Profile, bool>> CreateFilter(Dictionary<string, string> sourceOfFilter);
    }
}
