using Microsoft.AspNetCore.Mvc;
using WillMax.Applicatio.Service.Contracts;
using WillMax.Applicatio.Service.DTos;
using WillMax.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WillMax.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly IUserService _userService;
        private readonly ILogger<AuthenticationController> _logger;
        public AuthenticationController(IAccountService accountService, IUserService userService, ILogger<AuthenticationController> logger)
        {
            _accountService = accountService;
            _userService = userService;
            _logger = logger;
        }

        [HttpPost("login")]
        public async Task<LoginResponseDto> Login([FromBody] LoginRequestDto loginRequestDto)
        {
            return await _accountService.Login(loginRequestDto);
        }

        [HttpPost("register")]
        public async Task<User> Register([FromBody] RegisterRequestDto registerRequestDto)
        {
            _logger.LogError($"Received Request: {Request.Body}");
            return await _userService.Create(registerRequestDto);
        }
    }
}
