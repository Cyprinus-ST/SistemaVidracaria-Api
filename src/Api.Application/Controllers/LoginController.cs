using Api.Domain.DTO.Login;
using Api.Domain.DTO.User;
using Api.Domain.Interfaces.Services.Login;
using Api.Domain.Utils;
using Api.Service.Utils;
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

        [AllowAnonymous]
        [HttpPost]
        [Route("register")]
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

        [AllowAnonymous]
        [HttpPut]
        [Route("forgotPassword")]
        public async Task<ActionResult<ForgotPasswordOutput>> ForgotPassword([FromQuery] ForgotPasswordInput input, [FromServices] ILoginService service)
        {
            try
            {
                return Ok(await service.GenerateTokenByEmail(input.Email));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("recoveryTokenIsValid")]
        public async Task<ActionResult<object>> RecoveryTokenIsValid([FromQuery] string token, [FromServices] ILoginService service)
        {
            try
            {
                return Ok(await service.RecoveryTokenIsValid(token));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [AllowAnonymous]
        [HttpPatch]
        [Route("updatePassword")]
        public async Task<ActionResult<bool>> UpdatePassword([FromBody] UpdatePasswordInput input, [FromServices] ILoginService service)
        {
            return Ok(await service.UpdatePassword(input.id, input.password));
        }

    }
}
