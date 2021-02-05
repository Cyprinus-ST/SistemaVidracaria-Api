using Api.Domain.DTO.Provider;
using Api.Domain.Interfaces.Services.Provider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController: ControllerBase
    {
        [Authorize("Bearer")]
        [HttpGet]
        public async Task<object> GetAllProvider([FromQuery] Guid idUser, [FromServices] IProviderService service)
        {
            try
            {
                var result = await service.GetAllProvider(idUser);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpGet]
        [Route("{Id}")]
        public async Task<object> GetProvider([FromRoute] Guid Id, [FromServices] IProviderService service)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    var result = await service.GetByIdProvider(Id);
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
        public async Task<object> AddProvider([FromBody] AddInputProvider input, [FromServices] IProviderService service )
        {
            try
            {
                var result = await service.AddProvider(input);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpPut]
        public async Task<object> UpdateProvider([FromBody] UpdateInputProvider input, [FromServices] IProviderService service)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    var result = await service.UpdateProvider(input);
                    return Ok(result);
                }
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpDelete]
        public async Task<object> DeleteProvider([FromQuery] Guid Id, [FromServices] IProviderService service)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    var result = await service.DeleteProvider(Id);
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
