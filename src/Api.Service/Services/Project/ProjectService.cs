using Api.Domain.Interfaces.Services.Project;
using Api.Service.Utils;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
using Api.Domain.DTO.Project;
using Api.Domain.Entities.Project;
using Api.Domain.Interfaces.Repository;

namespace Api.Service.Services.Project
{
    public class ProjectService : IProjectService
    {

        public IMapper mapper;
        public IProjectRepository repository; 
        private IConfiguration configuration { get; }

        public ProjectService(IConfiguration _configuration, IMapper _mapper, IProjectRepository _repository)
        {
            configuration = _configuration;
            mapper = _mapper;
            repository = _repository;
        }
        public async Task<object> UploadFile(IFormFile file, Guid idProject, Guid idUser)
        {
            UploadFile up = new UploadFile(configuration);
            DateTime moment = DateTime.Now;

            try
            {
                if (file != null)
                {
                    string fileName = moment.Millisecond.ToString() + file.FileName;
                    string path = await up.Upload($"ProjectFiles/{idProject}", file, idUser, fileName);

                    return new
                    {
                        valid = true,
                        message = "Upload feito com sucesso!",
                        path = path
                    };
                }
                else
                {
                    return new
                    {
                        valid = false,
                        message = "Favor enviar um arquivo!"
                    };
                }
            }
            catch (Exception ex)
            {
                return new
                {
                    valid = false,
                    message = "Ocorreu um erro ao fazer o upload do arquivo:" + ex.Message,

                };
            }
        }

        public async Task<object> AddProject(AddProjectInput project)
        {
            try
            {
                var entity = mapper.Map<ProjectEntity>(project);

                if (string.IsNullOrEmpty(entity.ImageUrl))
                {
                    entity.ImageUrl = "Implementar imagem";
                }

                var projectType = await repository.FindProjectType(entity.ProjectType);

                if(projectType == null)
                {
                    throw new Exception("O tipo de projeto não foi encontrado na nossa base de dados!");
                }

                var result = await repository.InsertAsync(entity);

                if (result != null)
                {
                    return new
                    {
                        valid = true,
                        message = "Projeto cadastrado com sucesso!"
                    };

                }
                else
                {
                    throw new Exception("Ocorreu um erro ao cadastrar o Projeto!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
