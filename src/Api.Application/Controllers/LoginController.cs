using Api.Domain.DTO.User;
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
        [Route("Login")]
        public async Task<object> Login([FromBody] UserDTO loginDTO,[FromServices] ILoginService service)
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

        [AllowAnonymous]
        [HttpPost]
        [Route("Register")]
        public async Task<object> Register([FromBody] UserCreateDTO userCreateDTO, [FromServices] ILoginService service)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var result = await service.CreateUser(userCreateDTO);

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
