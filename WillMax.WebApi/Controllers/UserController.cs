﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WillMax.Applicatio.Service.Contracts;
using WillMax.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WillMax.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILogger<UserController> _logger;

        public UserController(IUserService userService, ILogger<UserController> logger)
        {
            _userService = userService;
            _logger = logger;
        }


        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await _userService.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        [Authorize(Roles = "ROLE_ADMIN")]
        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public async Task<User> Put(int id, [FromBody] User user)
        {
            return await _userService.Update(user);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _userService.Delete(id);
        }
    }
}
