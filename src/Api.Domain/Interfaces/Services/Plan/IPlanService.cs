using Api.Domain.DTO.Plan;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Plan
{
    public interface IPlanService
    {
        public Task<object> AddPlan(AddPlanInput input);
        public Task<IEnumerable<PlanDTO>> ListPlan();
    }
}
