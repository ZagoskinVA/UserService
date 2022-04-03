using LinqKit;
using System.Linq.Expressions;
using UserService.Interfaces;
using UserService.Models;

namespace UserService.Services
{
    public class FilterCollector : IFilterCollector
    {
        public Func<Profile, bool> CollectFilters(IEnumerable<IFilter> filters, Dictionary<string, string> filtersSource)
        {
            var predicateBuilder = PredicateBuilder.New<Profile>(true);
            foreach (var filter in filters) 
            {
                predicateBuilder.And(filter.CreateFilter(filtersSource));
            }
            return predicateBuilder.Compile();
        }
    }
}
