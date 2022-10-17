using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using React_.Net_App.Models;
using React_.Net_App.Services.Interfaces;

namespace React_.Net_App.Controllers
{
    [ApiController]
    [Route("api/v3/controller")]

    public class UserController : ControllerBase
    {
        // Injection of User Service
        private IUserService _userService;
        IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        // Register New User
        [HttpPost]
        [Route("registerNewUser")]

        public IActionResult RegisterNewUser(User newUser) 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(newUser);
            }

            var user = _userService.CreateUser(newUser);
            return Ok(user);
        }


        [HttpGet]
        [Route("getAllUsers")]
        public IActionResult GetAllUsers() 
        {
            var users = _userService.GetUsers(); 
            return Ok(users);
        }

        [HttpGet]
        [Route("getUserById")]
        public IActionResult GetUserById(int id)  
        {
            var user = _userService.GetUserById(id);            
            return Ok(user);
        }
    }
}
