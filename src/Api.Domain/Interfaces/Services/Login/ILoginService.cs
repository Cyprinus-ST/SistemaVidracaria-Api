using Api.Domain.DTO.Login;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Login
{
    public interface ILoginService
    {
        Task<object> DoLogin(LoginDTO user);
    }
}
