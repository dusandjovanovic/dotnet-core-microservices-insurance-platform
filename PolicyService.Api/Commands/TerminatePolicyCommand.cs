using System;
using MediatR;

namespace PolicyService.Api.Commands
{
    public class TerminatePolicyCommand : IRequest<TerminatePolicyResult>
    {
        public string PolicyNumber;
        
        public DateTime TerminationDate { get; set; }
    }
}