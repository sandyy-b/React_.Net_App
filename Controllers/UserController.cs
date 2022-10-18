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

        // Get Desired Users
        [HttpPost]
        [Route("getUsers")]
        public IActionResult GetUsers(string queryText)
        {
            var users = _userService.GetUsers(queryText);
            return Ok(users);
        }
    }
}
