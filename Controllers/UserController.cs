using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Interfaces;
using WebUtilities.Services;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet]
        public IActionResult Get([FromQuery]Dictionary<string, string> filters) 
        {
            var users = userService.GetUsers(filters);
            return Ok(JsonService.GetOkJson(users));
        }
    }
}
