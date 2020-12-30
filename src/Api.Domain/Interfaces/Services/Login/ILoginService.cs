using Api.Domain.DTO.User;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Login
{
    public interface ILoginService
    {
        Task<object> DoLogin(UserDTO user);
        Task<object> CreateUser(UserCreateDTO newUser);
    }
}
