using Api.Domain.Entities.Plan;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Repository
{
    public interface IPlanRepository : IRepository<PlanEntity>
    {
        Task<PlanEntity> FindByName(string name);
    }
}
