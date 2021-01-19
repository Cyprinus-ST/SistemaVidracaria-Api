using Api.Domain.DTO.User;
using Api.Domain.Interfaces.Services.User;
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

    public class UserController : ControllerBase
    {
        [Authorize("Bearer")]
        [HttpPut]
        public async Task<object> UpdateUser([FromBody] UserDTO user, [FromServices] IUserService service)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var result = await service.UpdateUser(user);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return StatusCode((int)HttpStatusCode.BadRequest, "Ocorreu um erro ao processar a sua requisição");
                }
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        [Authorize("Bearer")]
        [Route("uploadFile")]
        public async Task<object> UpdateAvatarFile([FromForm] IFormFile file, [FromForm] Guid idUser, [FromServices] IUserService service)
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
                    var result = await service.UpdateAvatarFile(file, idUser);

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
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Authorize("Bearer")]
        public async Task<object> GetAllUsers([FromServices]IUserService service)
        {
            try
            {
                return Ok(await service.GetAllUsers());
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet]
        [Route("{id}")]
        //[Authorize("Bearer")]
        public async Task<object> GetUser([FromRoute] Guid id, [FromServices] IUserService service)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await service.GetUser(id));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
