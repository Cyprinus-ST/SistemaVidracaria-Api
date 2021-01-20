using Api.Domain.DTO.Material;
using Api.Domain.Interfaces.Services.Material;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : ControllerBase
    {
        [HttpPost]
        public async Task<object> AddMaterial([FromBody] AddMaterialInput Material,[FromServices] IMaterialService service)
        {
            try
            {
                return null;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        [HttpGet]
        public async Task<object> GetAllMaterial([FromServices] IMaterialService service)
        {
            try
            {
                return null;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<object> GetMaterial([FromRoute] Guid id, [FromServices] IMaterialService service)
        {
            try
            {
                return null;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        [HttpPut]
        public async Task<object> UpdateMaterial([FromBody] AddMaterialInput Material,[FromServices] IMaterialService service)
        {
            try
            {
                return null;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        [HttpDelete]
        public async Task<object> DeleteMaterial([FromQuery] Guid id, [FromServices] IMaterialService service)
        {
            try
            {
                return null;
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
