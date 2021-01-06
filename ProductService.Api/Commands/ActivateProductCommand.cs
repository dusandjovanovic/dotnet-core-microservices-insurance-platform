using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductService.Api.Commands
{
    public class ActivateProductCommand : IRequest<ActivateProductResult>
    {
        public Guid ProductId { get; set; }
    }
}
