using System;
using MediatR;

namespace DashboardService.Api.Queries
{
    public class GetAgentSalesQuery : IRequest<GetAgentSalesResult>
    {
        public string AgentLogin { get; set; }
        
        public string ProductCode { get; set; }
        
        public DateTime SalesDateFrom { get; set; }
        
        public DateTime SalesDateTo { get; set; }
    }
}