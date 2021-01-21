using Api.Domain.DTO.Plan;
using Api.Domain.Interfaces.Services.Plan;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanController : ControllerBase
    {
        [Authorize("Bearer")]
        [HttpPost]
        public async Task<ActionResult<object>> AddPlan([FromBody] AddPlanInput input, [FromServices] IPlanService service)
        {
            try
            {
                await service.AddPlan(input);
                return Ok(new
                {
                    valid = true
                });
            } catch (Exception e)
            {
                return BadRequest(
                    new {
                        message = e.Message
                    }
                );
            }
        }

        [Authorize("Bearer")]
        [HttpGet]
        public async Task<ActionResult<object>> ListPlan([FromServices] IPlanService service)
        {
            try
            {
                var result = await service.ListPlan();
                return Ok(result);
            } catch (Exception e)
            {
                return BadRequest(
                   new
                   {
                       message = e.Message
                   }
               );
            }
        }

        [Authorize("Bearer")]
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<object>> UpdatePlan([FromRoute] Guid id, [FromBody] UpdatePlanInput input, [FromServices] IPlanService service)
        {
            try
            {
                var result = await service.UpdatePlan(id, input);
                return Ok(result);
            } catch(Exception e)
            {
                return BadRequest(
                  new
                  {
                      valid = false,
                      message = e.Message
                  }
                );
            }
        }

        [Authorize("Bearer")]
        [HttpPatch]
        public async Task<ActionResult<object>> DeletePlan([FromQuery] DeletePlanInput input, [FromServices] IPlanService service)
        {
            try
            {
                var result = await service.DeletePlan(input);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(
                  new
                  {
                      valid = false,
                      message = e.Message
                  }
                );
            }
        }
    }
}
