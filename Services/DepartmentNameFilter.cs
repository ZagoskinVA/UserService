using System.Linq.Expressions;
using UserService.Interfaces;
using UserService.Models;

namespace UserService.Services
{
    public class DepartmentNameFilter : IFilter
    {
        public Expression<Func<Profile, bool>> CreateFilter(Dictionary<string, string> sourceOfFilter)
        {
            var result = sourceOfFilter.TryGetValue("DepartmentName", out var value);
            if (result)
                return x => x.Department.Name == value;
            return x => true;
        }
    }
}
