using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PricingService.Api.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PricingService.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PricingController : ControllerBase
    {
        private readonly IMediator mediator;

        public PricingController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CalculatePriceCommand cmd)
        {
            var result = await mediator.Send(cmd);
            return new JsonResult(result);
        }
    }
}
