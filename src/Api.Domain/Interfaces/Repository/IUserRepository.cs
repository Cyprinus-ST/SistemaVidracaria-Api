using Api.Domain.Entities.User;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Repository
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<UserEntity> FindByLoginAndPassword(string email,string senha);
    }
}
