using Api.Domain.Entities.Plan;
using System;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Repository
{
    public interface IPlanUserRepository: IRepository<PlanUserEntity>
    {
        Task<PlanUserEntity> ExistsUsersInPlan(Guid id);
    }
}
