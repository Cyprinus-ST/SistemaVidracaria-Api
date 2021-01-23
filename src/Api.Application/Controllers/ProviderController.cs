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
        //[HttpGet]
        //public async Task<object> GetAllMaterial([FromQuery] Guid idUsere)
        //{
        //    try
        //    {
        //        var result = await service.GetAllMaterial(idUser);
        //        return Ok(result);
        //    }
        //    catch (Exception e)
        //    {
        //        return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
        //    }
        //}
    }
}
