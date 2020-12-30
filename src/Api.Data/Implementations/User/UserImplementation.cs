using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities.User;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Api.Data.Implementations
{
    public class UserImplementation : BaseRepository<UserEntity>, IUserRepository
    {
        private DbSet<UserEntity> _dataset;

        public UserImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<UserEntity>();
        }

        public async Task<UserEntity> FindByEmail(string email)
        {
            try
            {
                return await _dataset.FirstOrDefaultAsync(u => u.Email.Equals(email));
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<UserEntity> FindByLoginAndPassword(string email, string senha)
        {
            return await _dataset.FirstOrDefaultAsync(u => u.Email.Equals(email) && u.Password.Equals(senha));
        }
    }
}
