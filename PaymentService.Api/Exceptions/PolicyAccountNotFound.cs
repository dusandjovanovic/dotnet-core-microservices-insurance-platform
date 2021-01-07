using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentService.Api.Exceptions
{
    public class PolicyAccountNotFound : BussinesExceptions
    {
        public PolicyAccountNotFound(string accountNumber) :
            base($"Policy Account not found. Looking for account with number: {accountNumber}")
        {
        }
    }
}
