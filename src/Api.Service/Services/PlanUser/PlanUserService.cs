using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services.PlanUser;
using System;
using System.Threading.Tasks;

namespace Api.Service.Services.PlanUser
{
    public class PlanUserService : IPlanUserService
    {
        private IPlanUserRepository repository;

        public PlanUserService(IPlanUserRepository repository) {
            this.repository = repository;
        }

        public async Task<bool> ExistUsersinPlan(Guid id)
        {
            var planUser = await repository.ExistsUsersInPlan(id);
            if(planUser == null)
            {
                return false;
            } else
            {
                return true;
            }

        }
    }
}
