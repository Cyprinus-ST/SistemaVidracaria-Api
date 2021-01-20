using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.DTO.User;
using Api.Domain.Entities.Plan;
using Api.Domain.Entities.User;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Data.Implementations
{
    public class UserImplementation : BaseRepository<UserEntity>, IUserRepository
    {
        private DbSet<UserEntity> User;
        private DbSet<PlanEntity> Plan;
        private DbSet<PlanUserEntity> PlanUser;
        public UserImplementation(MyContext context) : base(context)
        {
            User = context.Set<UserEntity>();
            Plan = context.Set<PlanEntity>();
            PlanUser = context.Set<PlanUserEntity>();
        }

        public async Task<UserEntity> FindByEmail(string email)
        {
            try
            {
                return await User.FirstOrDefaultAsync(u => u.Email.Equals(email));
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<UserEntity> FindByLoginAndPassword(string email, string senha)
        {
            return await User.FirstOrDefaultAsync(u => u.Email.Equals(email) && u.Password.Equals(senha));
        }

        public async Task<UserEntity> FindByToken(string token)
        {
            return await User.FirstOrDefaultAsync(u => u.TokenPassword.Equals(token));
        }

        public async Task<List<UserPlanDTO>> FindUser()
        {

            try
            {
                List<UserPlanDTO> users =  (from u in User
                                           join pu in PlanUser
                                           on u.Id equals pu.idUser
                                           join p in Plan
                                           on pu.idPlan equals p.Id
                                           where u.Type == "user"
                                           select new UserPlanDTO
                                           {
                                               Id = u.Id,
                                               Name = u.Name,
                                               IdPlan = p.Id,
                                               CreateAt = u.CreateAt,
                                               NamePlan = p.Name,
                                               DateAcquisition = pu.dateAcquisition,
                                               DateExpired = pu.dateExpired,
                                               StatusPlan = pu.statusPlan

                                           }).ToList();
                return users;
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public async Task<UserPlanCompleteDTO> FindById(Guid id)
        {
            try
            {
                UserPlanCompleteDTO user = (from u in User
                                           join pu in PlanUser
                                           on u.Id equals pu.idUser
                                           join p in Plan
                                           on pu.idPlan equals p.Id
                                           where u.Id == id
                                           select new UserPlanCompleteDTO
                                           {
                                               Id = u.Id,
                                               Name = u.Name,
                                               IdPlan = p.Id,
                                               CreateAt = u.CreateAt,
                                               NamePlan = p.Name,
                                               DateAcquisition = pu.dateAcquisition,
                                               DateExpired = pu.dateExpired,
                                               StatusPlan = pu.statusPlan,
                                               Type = u.Type,
                                               CEP = u.CEP,
                                               City = u.City,
                                               Complement = u.Complement,
                                               Country = u.Country,
                                               CPF = u.CPF,
                                               Description = p.Description,
                                               Email = u.Email,
                                               Neighborhood = u.Neighborhood,
                                               Number = u.Number,
                                               Phone = u.Phone,
                                               Price = p.Price,
                                               State = u.State,
                                               Status = p.Status,
                                               Street = u.Street,
                                               PathAvatar = u.PathAvatar
                                           }).FirstOrDefault();
                return user;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
