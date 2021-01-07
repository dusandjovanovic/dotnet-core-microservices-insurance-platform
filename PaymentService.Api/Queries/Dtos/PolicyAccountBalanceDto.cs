﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentService.Api.Queries.Dtos
{
    public class PolicyAccountBalanceDto
    {
        public string PolicyAccountNumber { get; set; }
        public string PolicyNumber { get; set; }
        public decimal Balance { get; set; }
    }
}
