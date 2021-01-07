using System.Collections.Generic;
using DashboardService.Api.Queries.Dtos;

namespace DashboardService.Api.Queries
{
    public class GetAgentSalesResult
    {
        public IDictionary<string, SalesDto> PerAgentTotal { get; set; }
    }
}