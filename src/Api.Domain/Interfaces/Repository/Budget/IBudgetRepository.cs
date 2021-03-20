using Api.Domain.DTO.Budget;
using Api.Domain.Entities.Budget;
using Api.Domain.Entities.ProjectBudgetEntity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Repository
{
    public interface IBudgetRepository : IRepository<BudgetEntity>
    {
        Task<bool> ExistBudgetWithProject(Guid idProject);
        Task<bool> ExistBudgetWithCostumer(Guid idProject);
        Task<BudgetCompleteDTO> GetBudgetComplete(Guid idBudget);
        Task<List<BudgetEntity>> FindByIdUser(Guid IdUser);
        Task<ProjectBudgetEntity> InsertProjectBudget(ProjectBudgetEntity projectBudget);
    }
}
