using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentService.Api.Queries
{
    public class GetAccountBalanceQuery : IRequest<GetAccountBalanceQueryResult>
    {
        public string PolicyNumber { get; set; }
    }
}
