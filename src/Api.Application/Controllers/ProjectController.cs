using Api.Domain.DTO.Project;
using Api.Domain.Interfaces.Services.Project;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize("Bearer")]
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

        [Authorize("Bearer")]
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

        [Authorize("Bearer")]
        [HttpPut]
        public async Task<object> UpdateProject([FromBody] UpdateProjectInput Project, [FromServices] IProjectService service)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    var result = await service.UpdateProject(Project);
                    return Ok(result);
                }
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpPost]
        [Route("ListFiltered")]
        public object ListProjectsFiltered([FromBody] FilterProjectDTO filter, [FromServices] IProjectService service)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    var result = service.ListProjectFiltered(filter);
                    return Ok(result);
                }
             
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [Authorize("Bearer")]
        [HttpGet]
        [Route("{id}")]
        [Authorize("Bearer")]
        public async Task<object> GetProject([FromRoute] Guid id, [FromServices] IProjectService service)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await service.GetProject(id));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [Authorize("Bearer")]
        [HttpGet]
        [Route("ProjectType")]
        public async Task<object> GetProjectType([FromServices] IProjectService service)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await service.GetProjectType());
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [Authorize("Bearer")]
        [HttpGet]
        [Route("GlassColor")]
        public async Task<object> GetGlassColor([FromServices] IProjectService service)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await service.GetGlassColor());
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [Authorize("Bearer")]
        [HttpGet]
        [Route("AluminiumColor")]
        public async Task<object> GetAluminiumColor([FromServices] IProjectService service)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await service.GetAluminiumColor());
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [Authorize("Bearer")]
        [HttpGet]
        [Route("StructureColor")]
        public async Task<object> GetStructureColor([FromServices] IProjectService service)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await service.GetStructureColor());
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [Authorize("Bearer")]
        [HttpDelete]
        public async Task<object> DeleteProject([FromQuery] Guid ID, [FromServices] IProjectService service)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    var result = await service.DeleteProject(ID);
                    return Ok(result);
                }
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
