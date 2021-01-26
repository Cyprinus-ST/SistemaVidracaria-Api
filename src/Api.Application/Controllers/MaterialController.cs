using Api.Domain.DTO.Material;
using Api.Domain.Interfaces.Services.Material;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : ControllerBase
    {
        [Authorize("Bearer")]
        [HttpPost]
        public async Task<object> AddMaterial([FromBody] AddMaterialInput Material,[FromServices] IMaterialService service)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    var result = await service.AddMaterial(Material);

                    if (result != null)
                    {
                        return Ok(result);
                    }
                    else
                    {
                        return BadRequest("Ocorreu um erro ao tentar cadastrar o material!");
                    }
                }

            }
            catch (Exception e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpGet]
        public async Task<object> GetAllMaterial([FromQuery] Guid idUser, [FromServices] IMaterialService service)
        {
            try
            {
                var result = await service.GetAllMaterial(idUser);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpGet]
        [Route("{id}")]
        public async Task<object> GetMaterial([FromRoute] Guid id, [FromServices] IMaterialService service)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    var result = await service.GetMaterialById(id);
                    return Ok(result);
                }
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpPut]
        public async Task<object> UpdateMaterial([FromBody] UpdateMaterialInput Material,[FromServices] IMaterialService service)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    var result = await service.UpdateMaterial(Material);
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
        public async Task<object> DeleteMaterial([FromQuery] Guid id, [FromServices] IMaterialService service)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    var result = await service.DeleteMaterial(id);
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
