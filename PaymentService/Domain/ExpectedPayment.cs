using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.Domain
{
    public class ExpectedPayment : AccountingEntry
    {
        protected ExpectedPayment() : base()
        { }

        public ExpectedPayment(PolicyAccount policyAccount, DateTimeOffset creationDate, DateTimeOffset effectiveDate, decimal amount) :
                base(policyAccount, creationDate, effectiveDate, amount)
        { }

        public override decimal Apply(decimal state)
        {
            return state - Amount;
        }
    }
}
