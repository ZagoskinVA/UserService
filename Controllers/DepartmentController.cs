using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Interfaces;
using WebUtilities.Services;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            if(departmentRepository == null)
                throw new ArgumentNullException(nameof(departmentRepository));
            this.departmentRepository = departmentRepository;
        }
        [HttpGet]
        public IActionResult Get() 
        {
            return Ok(JsonService.GetOkJson(departmentRepository.GetDepartments()));
        }
    }
}
