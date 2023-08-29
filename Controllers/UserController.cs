using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project_management_system_backend.Models;
using project_management_system_backend.Repostories;

namespace project_management_system_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            try
            {
                return Ok(_userRepository.GetAllUsers());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult CreatUser(User newUser)
        {
            try
            {
                return Ok(_userRepository.CreatUser(newUser));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
