using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductService.Api.Commands
{
    public class DiscontinueProductCommand : IRequest<DiscontinueProductResult>
    {
        public Guid ProductId { get; set; }
    }
}
