using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.Domain
{
    public class OutPayment : AccountingEntry
    {
        protected OutPayment() : base()
        { }

        public OutPayment(PolicyAccount policyAccount, DateTimeOffset creationDate, DateTimeOffset effectiveDate, decimal amount) :
                base(policyAccount, creationDate, effectiveDate, amount)
        { }

        public override decimal Apply(decimal state)
        {
            return state - Amount;
        }
    }
}
