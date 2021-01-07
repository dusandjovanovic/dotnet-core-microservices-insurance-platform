using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.Domain
{
    public class PolicyAccountNumberGenerator
    {
        public string Generate()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
