using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UserService.DataBase;
using UserService.Interfaces;
using UserService.Models;

namespace UserService.Services
{
    public class UserRepository: IUserRepository
    {
        private readonly UserContext context;

        public UserRepository(UserContext context)
        {
            if(context == null)
                throw new ArgumentNullException(nameof(context));
            this.context = context;
        }

        public IEnumerable<User> GetUsers(Func<Profile, bool> predicate)
        {
            return context.Profiles.Include(x => x.Account).Include(x => x.Department)
                .Where(predicate).Select(x => new User 
                {
                    Profile = new ProfileViewModel 
                    {
                        Id = x.Id,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        AccountId = x.AccountId,
                        DepartmentId = x.DepartmentId,
                        Department = x.Department
                    },
                    Account = x.Account,
                }).ToList();
        }
    }
}
