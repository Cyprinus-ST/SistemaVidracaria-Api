using Api.Domain.DTO.Project;
using Api.Domain.Entities.Project;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Repository
{
    public interface IProjectRepository : IRepository<ProjectEntity>
    {
        Task<List<ProjectTypeEntity>> ListProjectType();
        Task<ProjectTypeEntity> FindProjectType(int Id);
        List<ProjectEntity> FindProjectFiltered(FilterProjectDTO filter, out int pages);
        Task<bool> ExistProject(Guid idProject);
    }
}
