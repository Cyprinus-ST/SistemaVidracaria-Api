using Api.Domain.DTO.Login;
using Api.Domain.Interfaces.Services.Login;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost]
        public async Task<object> Login([FromBody] LoginDTO loginDTO,[FromServices] ILoginService service)
        {

            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                if (loginDTO == null)
                {
                    return BadRequest();
                }

                var result = await service.DoLogin(loginDTO);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }

            }
            catch (Exception e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
