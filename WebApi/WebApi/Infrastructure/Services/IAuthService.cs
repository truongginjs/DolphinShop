using System.Threading.Tasks;
using WebApi.DTOs.Requests.Auth;
using WebApi.DTOs.Responses.Auth;

namespace WebApi.Infrastructure.Services
{
    public interface IAuthService
    {
        Task<UserDataResDTO> LoginAsync(UserLoginReqDTO UserForm);
        Task<bool> LogoutAsync();
        Task<UserDataResDTO> RefreshTokenAsync(string refreshToken);
        Task<UserDataResDTO> RegisterAsync(UserRegisterReqDTO registerUser);
    }
}