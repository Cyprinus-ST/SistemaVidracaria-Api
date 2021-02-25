using Api.Domain.DTO.Budget;
using Api.Domain.Entities.Budget;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Budget
{
    public interface IBudgetService
    {
        public Task<object> AddBudget(AddBudgetInput Budget);
    }
}
