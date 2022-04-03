using UserService.Models;

namespace UserService.Interfaces
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
    }
}
