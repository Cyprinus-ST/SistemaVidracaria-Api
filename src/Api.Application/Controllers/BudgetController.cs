using Api.Domain.DTO.Budget;
using Api.Domain.Interfaces.Services.Budget;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetController : ControllerBase
    {
        [HttpPost]
        public async Task<object> AddBudget([FromBody] AddBudgetInput Budget, [FromServices] IBudgetService service)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    var result = await service.AddBudget(Budget);

                    if (result != null)
                    {
                        return Ok(result);
                    }
                    else
                    {
                        return BadRequest("Ocorreu um erro ao tentar cadastrar o orçamento!");
                    }
                }

            }
            catch (Exception e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
