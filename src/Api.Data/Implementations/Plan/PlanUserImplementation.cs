using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities.Plan;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations.Plan
{
    public class PlanUserImplementation: BaseRepository<PlanUserEntity>, IPlanUserRepository
    {
        private DbSet<PlanUserEntity> planUser;

        public PlanUserImplementation(MyContext context) : base(context)
        {
            planUser = context.Set<PlanUserEntity>();
        }

    }
}
