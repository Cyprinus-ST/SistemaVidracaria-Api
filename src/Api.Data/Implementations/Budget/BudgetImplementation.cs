using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities.Budget;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Data.Implementations.Budget
{
    public class BudgetImplementation : BaseRepository<BudgetEntity>, IBudgetRepository
    {
        private DbSet<BudgetEntity> Budget;

        public BudgetImplementation(MyContext context) : base(context)
        {
            Budget = context.Set<BudgetEntity>();
        }

        public Task<bool> ExistBudget(Guid idProject)
        {
            bool result = Budget.Any(b => b.IdProject.Equals(idProject));

            return Task.FromResult(result);

        }
    }
}
