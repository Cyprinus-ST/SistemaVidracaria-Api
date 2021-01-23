using System;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.PlanUser
{
    public interface IPlanUserService
    {
        Task<bool> ExistUsersinPlan(Guid id);
    }
}
