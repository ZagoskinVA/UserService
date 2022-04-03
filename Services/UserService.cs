using UserService.Interfaces;
using UserService.Models;

namespace UserService.Services
{
    public class UserService : IUserService
    {
        private readonly IFilterCollector filterCollector;
        private readonly IUserRepository userRepository;
        public UserService(IFilterCollector filterCollector, IUserRepository userRepository)
        {
            if(filterCollector == null)
                throw new ArgumentNullException(nameof(filterCollector));
            if(userRepository == null)
                throw new ArgumentNullException(nameof(userRepository));
            this.filterCollector = filterCollector;
            this.userRepository = userRepository;
        }
        public IEnumerable<User> GetUsers(Dictionary<string, string> filtersSource)
        {
            var predicates = filterCollector.CollectFilters(new List<IFilter>
            {
                new DepartmentNameFilter()
            }, filtersSource);

            return userRepository.GetUsers(predicates);
        }
    }
}
