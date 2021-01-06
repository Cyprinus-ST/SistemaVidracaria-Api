using Api.Domain.DTO.User;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.User
{
    public interface IUserService
    {
        Task<object> UpdateUser(UserDTO user);
    }
}
