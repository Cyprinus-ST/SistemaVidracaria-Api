using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MercadoPago;
using Api.Domain.DTO.Payment;
using Api.Domain.Interfaces.Services.Payment;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        [Authorize("Bearer")]
        [HttpPost]
        [Route("/product")]
        public async Task AddProduct([FromBody] AddProductInput input, [FromServices] IPaymentService service)
        {
            //TODO: CAIO
        }
    }
}
