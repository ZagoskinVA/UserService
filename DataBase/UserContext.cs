using Microsoft.EntityFrameworkCore;
using UserService.Models;

namespace UserService.DataBase
{
    public class UserContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Department> Departments { get; set; }
        public UserContext(DbContextOptions<UserContext> options): base(options)
        {
            Database.EnsureCreated();
        }
    }
}
