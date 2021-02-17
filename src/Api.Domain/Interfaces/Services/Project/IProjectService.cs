using Api.Domain.DTO.Project;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Project
{
    public interface IProjectService 
    {
        Task<object> UploadFile(IFormFile file, Guid idProject,Guid idUser);
        Task<object> AddProject(AddProjectInput project);
        Task<object> UpdateProject(UpdateProjectInput project);
        object ListProjectFiltered(FilterProjectDTO filter);
        Task<object> GetProject(Guid id);
        Task<object> GetProjectType();
    }
}
