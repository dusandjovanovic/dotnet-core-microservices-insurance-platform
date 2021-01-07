using PaymentService.Api.Queries.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentService.Api.Queries
{
    public class GetAccountBalanceQueryResult
    {
        public PolicyAccountBalanceDto Balance { get; set; }
    }
}
