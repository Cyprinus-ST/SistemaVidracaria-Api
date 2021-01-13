using Api.Domain.DTO.User;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.User
{
    public interface IUserService
    {
        Task<object> UpdateUser(UserDTO user);
        Task<object> UpdateAvatarFile(IFormFile file,Guid idUser);
        Task<object> GetAllUsers();
        Task<object> GetUser(Guid id);

    }
}
