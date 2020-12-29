using Api.Data.Context;
using Api.Domain.Entities.User;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Api.Data.Repository.Login
{
    class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        private DbSet<UserEntity> _dataset;
        public UserRepository(MyContext context) : base(context)
        {
            _dataset = context.Set<UserEntity>();
        }

        public async Task<UserEntity> FindByLoginAndPassword(string email, string senha)
        {
            try
            {
                return await _dataset.FirstOrDefaultAsync(u => u.Email.Equals(email) && u.Senha.Equals(senha));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
