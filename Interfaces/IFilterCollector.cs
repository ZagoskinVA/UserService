using System.Linq.Expressions;
using UserService.Models;

namespace UserService.Interfaces
{
    public interface IFilterCollector
    {
        Func<Profile, bool> CollectFilters(IEnumerable<IFilter> filters, Dictionary<string, string> filtersSource);
    }
}
