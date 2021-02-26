using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.DTO.Budget;
using Api.Domain.Entities.Budget;
using Api.Domain.Entities.Costumer;
using Api.Domain.Entities.Project;
using Api.Domain.Entities.User;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Data.Implementations.Budget
{
    public class BudgetImplementation : BaseRepository<BudgetEntity>, IBudgetRepository
    {
        private DbSet<BudgetEntity> Budget;
        private DbSet<CostumerEntity> Costumers;
        private DbSet<ProjectEntity> Project;
        private DbSet<UserEntity> User;

        public BudgetImplementation(MyContext context) : base(context)
        {
            Budget = context.Set<BudgetEntity>();
            Costumers = context.Set<CostumerEntity>();
            Project = context.Set<ProjectEntity>();
            User = context.Set<UserEntity>();
        }

        public Task<bool> ExistBudgetWithCostumer(Guid idCostumer)
        {
            bool result = Budget.Any(b => b.IdCostumer.Equals(idCostumer));

            return Task.FromResult(result);
        }

        public Task<bool> ExistBudgetWithProject(Guid idProject)
        {
            bool result = Budget.Any(b => b.IdProject.Equals(idProject));

            return Task.FromResult(result);

        }

        public async Task<List<BudgetEntity>> FindByIdUser(Guid IdUser)
        {
            try
            {
                List<BudgetEntity> budget = Budget.Where(c => c.IdUser.Equals(IdUser)).ToList();

                return budget;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<BudgetCompleteDTO> GetBudgetComplete(Guid idBudget)
        {
            try
            {
                BudgetCompleteDTO budget = (from b in Budget
                                            join u in User
                                            on b.IdUser equals u.Id
                                            join c in Costumers
                                            on b.IdCostumer equals c.Id
                                            join p in Project
                                            on b.IdProject equals p.Id
                                            where b.Id == idBudget
                                            select new BudgetCompleteDTO
                                            {
                                                Id = b.Id,
                                                IdCostumer = b.IdCostumer,
                                                CreateAt = b.CreateAt,
                                                Description = b.Description,
                                                Discount = b.Discount,
                                                HeightValue = b.HeightValue,
                                                IdProject = b.IdProject,
                                                IdUser = b.IdUser,
                                                MeterValue = b.MeterValue,
                                                Total = b.Total,
                                                UpdateAt = b.UpdateAt,
                                                WidthValue = b.WidthValue,
                                                NumberGlassProject = p.NumberGlass,
                                                DescriptionProject = p.Descripition,
                                                EmailCostumer = c.Email,
                                                NameCostumer = c.Name,
                                                Phone = c.Phone,
                                                ImageUrlProject = p.ImageUrl,
                                                TitleProject = p.Title,
                                                TypeProject = p.ProjectType,
                                                NameUser = u.Name,
                                                Status = b.Status
                                            }).FirstOrDefault();

                return Task.FromResult(budget);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
