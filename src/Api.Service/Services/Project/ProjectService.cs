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
        public IBudgetRepository budgetRepository;
        private IConfiguration configuration { get; }

        public ProjectService(IConfiguration _configuration, IMapper _mapper, IProjectRepository _repository, IBudgetRepository _budgetRepository)
        {
            configuration = _configuration;
            mapper = _mapper;
            repository = _repository;
            budgetRepository = _budgetRepository;
        }

        public async Task<object> UploadFile(IFormFile file, Guid idProject, Guid idUser)
        {
            UploadFile up = new UploadFile(configuration);
            DateTime moment = DateTime.Now;
            ProjectEntity project = new ProjectEntity();

            try
            {
                if (file != null)
                {
                    string fileName = moment.Millisecond.ToString() + file.FileName;
                    string path = await up.Upload($"ProjectFiles/{idProject}", file, idUser, fileName);

                    if (!string.IsNullOrEmpty(path))
                    {
                        project = await repository.SelectAsync(idProject);
                        project.ImageUrl = path;
                        var update = mapper.Map<UpdateProjectInput>(project);
                        return await UpdateProject(update);
                    }
                    else
                    {
                        throw new Exception("Não foi possível salvar o arquivo!");
                    }

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
                    entity.ImageUrl = "sem_imagem.jpg";
                }

                var projectType = await repository.FindProjectType(entity.ProjectType);

                if (projectType == null)
                {
                    throw new Exception("O tipo de projeto não foi encontrado na nossa base de dados!");
                }

                var result = await repository.InsertAsync(entity);

                if (result != null)
                {
                    return new
                    {
                        valid = true,
                        message = "Projeto cadastrado com sucesso!",
                        idProject = result.Id
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

        public async Task<object> UpdateProject(UpdateProjectInput Project)
        {
            try
            {
                var project = await repository.SelectAsync(Project.Id);

                if (project == null)
                    throw new Exception("Não foi encontrado esse projeto na nossa base de dados!");

                var entity = mapper.Map<ProjectEntity>(Project);
                await repository.UpdateAsync(entity);

                return new
                {
                    valid = true,
                    message = "Projeto salvo com sucesso!"
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        public object ListProjectFiltered(FilterProjectDTO filter)
        {
            try
            {
                var result = repository.FindProjectFiltered(filter, out int pages);

                return new
                {
                    data = result,
                    pages = pages,
                    actualPage = filter.Page
                };

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<object> GetProject(Guid id)
        {
            try
            {
                var result = await repository.SelectAsync(id);
                if (result != null)
                {
                    return new
                    {
                        valid = true,
                        result
                    };
                }
                else
                {
                    throw new Exception("Não encontramos nenhum projeto com esse registro!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<object> GetProjectType()
        {
            try
            {
                var result = await repository.ListProjectType();
                if (result != null)
                {
                    return new
                    {
                        valid = true,
                        result
                    };
                }
                else
                {
                    throw new Exception("Não encontramos tipo de projeto!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<object> DeleteProject(Guid Id)
        {
            try
            {
                bool budget = await budgetRepository.ExistBudgetWithProject(Id);

                if (budget == false)
                {
                    var result = await repository.DeleteAsync(Id);
                    if (result)
                    {
                        return new
                        {
                            valid = true,
                            message = "Projeto excluído com sucesso!"
                        };
                    }
                    else
                    {
                        throw new Exception("Ocorreu um erro ao excluir o Projeto, tente novamente mais tarde!");
                    }
                }
                else
                {
                    throw new Exception("Não foi possível excluir o projeto porque ele está vinculado a um ou mais orçamentos!");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<object> GetAllColors()
        {
            try
            {
                var GlassColor = await repository.GetColorGlassColor();
                var StructureColor = await repository.GetStructureColor();
                var AluminiumColor = await repository.GetAluminiumColor();

                return new
                {
                    data = new
                    {
                        GlassColor,
                        StructureColor,
                        AluminiumColor
                    }
                };

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
