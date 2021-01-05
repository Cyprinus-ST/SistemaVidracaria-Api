using Api.Domain.DTO.Login;
using Api.Domain.DTO.User;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Login
{
    public interface ILoginService
    {
        Task<object> DoLogin(LoginDTO user);
        Task<object> CreateUser(UserCreateDTO newUser);
        Task<object> GenerateTokenByEmail(string email);
    }
}
