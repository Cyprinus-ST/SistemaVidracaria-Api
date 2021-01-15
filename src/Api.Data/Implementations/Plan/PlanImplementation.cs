using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities.Plan;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations.Plan
{
    public class PlanImplementation : BaseRepository<PlanEntity>, IPlanRepository
    {
        private DbSet<PlanEntity> _dataset;

        public PlanImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<PlanEntity>();
        }
    }
}
