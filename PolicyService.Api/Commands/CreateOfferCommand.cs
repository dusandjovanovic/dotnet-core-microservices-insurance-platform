using System;
using System.Collections.Generic;
using MediatR;
using PolicyService.Api.Commands.Dtos;

namespace PolicyService.Api.Commands
{
    public class CreateOfferCommand : IRequest<CreatePolicyResult>
    {
        public string ProductCode { get; set; }
        
        public DateTime PolicyFrom { get; set; }
        
        public DateTime PolicyTo { get; set; }
        
        public List<string> SelectedCovers { get; set; }
        
        public List<QuestionAnswer> Answers { get; set; }
    }

    public class CreateOfferByAgentCommand : CreateOfferCommand, IRequest<CreateOfferResult>
    {
        public string AgentLogin { get; set; }

        public CreateOfferByAgentCommand(string agentLogin, CreateOfferCommand command)
        {
            AgentLogin = agentLogin;
            ProductCode = command.ProductCode;
            PolicyFrom = command.PolicyFrom;
            PolicyTo = command.PolicyTo;
            SelectedCovers = command.SelectedCovers;
            Answers = command.Answers;
        }
    }
}