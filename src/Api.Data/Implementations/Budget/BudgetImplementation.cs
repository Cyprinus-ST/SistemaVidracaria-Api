using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.DTO.Budget;
using Api.Domain.Entities.Budget;
using Api.Domain.Entities.Costumer;
using Api.Domain.Entities.Project;
using Api.Domain.Entities.ProjectBudgetEntity;
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

        protected readonly MyContext _context;
        private DbSet<BudgetEntity> Budget;
        private DbSet<CostumerEntity> Costumers;
        private DbSet<ProjectEntity> Project;
        private DbSet<UserEntity> User;
        private DbSet<ProjectBudgetEntity> ProjectBudgetDataBase;

        public BudgetImplementation(MyContext context) : base(context)
        {
            _context = context;
            Budget = context.Set<BudgetEntity>();
            Costumers = context.Set<CostumerEntity>();
            Project = context.Set<ProjectEntity>();
            User = context.Set<UserEntity>();
            ProjectBudgetDataBase = context.Set<ProjectBudgetEntity>();
        }

        public Task<bool> ExistBudgetWithCostumer(Guid idCostumer)
        {
            bool result = Budget.Any(b => b.IdCostumer.Equals(idCostumer));

            return Task.FromResult(result);
        }

        public Task<bool> ExistBudgetWithProject(Guid idProject)
        {
            bool result = ProjectBudgetDataBase.Any(b => b.IdProject.Equals(idProject));
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
            throw new NotImplementedException();
        }

        public async Task<ProjectBudgetEntity> InsertProjectBudget(ProjectBudgetEntity projectBudget)
        {
            try
            {

                if (projectBudget.Id == Guid.Empty)
                {
                    projectBudget.Id = Guid.NewGuid();
                }
                projectBudget.CreateAt = DateTime.UtcNow;

                ProjectBudgetDataBase.Add(projectBudget);

                await _context.SaveChangesAsync();

                return projectBudget;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
