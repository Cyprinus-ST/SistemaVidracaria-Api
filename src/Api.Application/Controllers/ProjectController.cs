using Api.Domain.DTO.Project;
using Api.Domain.Interfaces.Services.Project;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        [HttpPost]
        [Route("uploadFile")]
        public async Task<object> UploadFile([FromForm] IFormFile file, [FromForm] Guid idProject, [FromForm] Guid idUser,[FromServices]IProjectService service)
        {
            try
            {
                if(file == null)
                {
                    return BadRequest(new
                    {
                        message = "Error: O parâmetro file não pode ser nulo."
                    });
                }
                else
                {
                    var result = await service.UploadFile(file, idProject, idUser);

                    if (result != null)
                    {
                        return Ok(result);
                    }
                    else
                    {
                        return StatusCode((int)HttpStatusCode.BadRequest, "Ocorreu um erro ao processar a sua requisição");
                    }
                }
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        [HttpPost]
        public async Task<object> AddProject([FromBody] AddProjectInput Project,[FromServices] IProjectService service)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    var result = await service.AddProject(Project);

                    if (result != null)
                    {
                        return Ok(result);
                    }
                    else
                    {
                        return BadRequest("Ocorreu um erro ao tentar cadastrar o projeto!");
                    }
                }

            }
            catch (Exception e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

    }
}
