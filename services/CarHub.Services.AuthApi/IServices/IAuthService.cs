using CarHub.Services.AuthApi.Dto;

namespace CarHub.Services.AuthApi;

public interface IAuthService
{
    Task<LoginResponseDto> Register(RegisterDto registerDto);

    Task<LoginResponseDto> Login(LoginRequestDto registerDto);
}
