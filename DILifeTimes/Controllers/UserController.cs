using DILifeTimes.Models;
using DILifeTimes.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DILifeTimes.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        private IUserService _userService2;
        public UserController(IUserService userService, IUserService userService2)
        {
            _userService = userService;
            _userService2 = userService2;
        }

        [HttpGet]
        public IEnumerable<UserModel> GetUsers()
        {
            return _userService.GetAll();
        }

        [HttpPost]
        public UserModel Create(UserModel user)
        {
            var result = _userService.Create(user);

            var users = _userService.GetAll();
            var users2 = _userService2.GetAll();

            return result;
        }
    }
}
