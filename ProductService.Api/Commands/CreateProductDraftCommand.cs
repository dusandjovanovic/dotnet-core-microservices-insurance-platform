using MediatR;
using ProductService.Api.Commands.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductService.Api.Commands
{
    public class CreateProductDraftCommand : IRequest<CreateProductDraftResult>
    {
        public ProductDraftDto ProductDraft { get; set; }
    }
}
