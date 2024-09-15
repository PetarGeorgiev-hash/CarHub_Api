using CarHub.Services.AuthApi.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CarHub.Services.AuthApi.Controllers.AuthController
{
    [ApiController]
    [Route("/api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<LoginResponseDto> Register([FromBody] RegisterDto registerDto)
        {
            return await _authService.Register(registerDto);
        }
    }
}