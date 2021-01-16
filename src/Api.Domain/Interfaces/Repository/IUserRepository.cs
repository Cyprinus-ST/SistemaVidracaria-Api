using Api.Domain.DTO.User;
using Api.Domain.Entities.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Repository
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<UserEntity> FindByLoginAndPassword(string email,string senha);
        Task<UserEntity> FindByEmail(string email);
        Task<UserEntity> FindByToken(string token);
        Task<List<UserPlanDTO>> FindUser();
    }
}
