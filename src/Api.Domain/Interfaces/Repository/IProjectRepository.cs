using Api.Domain.Entities.Project;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Repository
{
    public interface IProjectRepository : IRepository<ProjectEntity>
    {
        Task<List<ProjectTypeEntity>> ListProjectType();
        Task<ProjectTypeEntity> FindProjectType(int Id);
    }
}
