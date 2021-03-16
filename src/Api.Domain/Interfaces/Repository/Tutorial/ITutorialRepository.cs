using Api.Domain.Entities.Tutorial;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Repository.Tutorial
{
    public interface ITutorialRepository : IRepository<TutorialEntity>
    {
        public Task<List<TutorialEntity>> GetAll();
    }
}
