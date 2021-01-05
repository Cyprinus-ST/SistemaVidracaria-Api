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
        public async Task<object> ForgotPassword([FromQuery] ForgotPasswordInput input, [FromServices] ILoginService service)
        {
            var result = await service.GenerateTokenByEmail(input.Email);
            var bodyEmail = new ForgotPassworBodyEmail();

            const string subject = "Redefinir sua senha";
            string FORGOT_PASSWORD_BODY = bodyEmail.FORGOT_PASSWORD_BODY;

            var clientSmtp = new SmptClient();
            clientSmtp.SendEmail(input.Email, null, null, subject, FORGOT_PASSWORD_BODY);
            return Ok(result);
        }
    }
}
