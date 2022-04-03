using UserService.DataBase;
using UserService.Interfaces;
using UserService.Models;

namespace UserService.Services
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly UserContext context;
        public DepartmentRepository(UserContext context)
        {
            if(context == null)
                throw new ArgumentNullException(nameof(context));
            this.context = context;
        }
        public IEnumerable<Department> GetDepartments()
        {
            return context.Departments.AsEnumerable();
        }
    }
}
