using Business;
using Common;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsManagement.Controllers
{
    public class UserController : ControllerBase
    {
        private IUserService _userService;


        // quick constructor - tastezi 'ctor' si apesi TAB de 2 ori
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IEnumerable<UserDetailDTO> GetAll()
        {
            return _userService.GetAll();

        }

        [HttpPost]
        public IActionResult Create([FromBody] User user)
        {
            var z = 75;
            var result = _userService.Create(user);
            return Ok(result);
        }
    }
}

