using Api.Domain.Interfaces.Services.Project;
using Api.Service.Utils;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Api.Service.Services.Project
{
    public class ProjectService : IProjectService
    {

        private readonly IMapper mapper;
        private IConfiguration configuration { get; }

        public ProjectService(IConfiguration _configuration, IMapper _mapper)
        {
            configuration = _configuration;
            mapper = _mapper;
        }
        public async Task<object> UploadFile(IFormFile file, Guid idProject)
        {
            UploadFile up = new UploadFile(configuration);
            DateTime moment = DateTime.Now;

            try
            {
                if (file != null)
                {
                    string fileName = moment.Millisecond.ToString() + file.FileName;
                    string path = await up.Upload("ProjectFiles", file, idProject, fileName);

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
    }
}
