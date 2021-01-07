using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentService.Api.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IMediator mediator;

        public PaymentController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("accounts/{policyNumber}")]
        public async Task<ActionResult> AccountBalance(string policyNumber)
        {
            var result = await mediator.Send(new GetAccountBalanceQuery { PolicyNumber = policyNumber });
            return new JsonResult(result);
        }
    }
}
