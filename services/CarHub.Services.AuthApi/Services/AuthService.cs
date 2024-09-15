using CarHub.Services.AuthApi.Dto;
using CarHub.Services.AuthApi.Models;
using Microsoft.AspNetCore.Identity;

namespace CarHub.Services.AuthApi;

public class AuthService : IAuthService
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;

    public Task<LoginResponseDto> Login(LoginRequestDto registerDto)
    {
        throw new NotImplementedException();
    }

    public Task<LoginResponseDto> Register(RegisterDto registerDto)
    {
        throw new NotImplementedException();
    }
}
