using Api.Domain.DTO.Budget;
using System;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Budget
{
    public interface IBudgetService
    {
        public Task<object> AddBudget(AddBudgetInput Budget);
        public Task<object> UpdateBudget(UpdateBudgetInput Budget);
        public Task<object> DeleteBudget(Guid id);
        public Task<object> GetAllBudget(Guid IdUser);
        public Task<object> GetBudgetById(Guid id);
    }
}
