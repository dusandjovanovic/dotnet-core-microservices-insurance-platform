using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.Jobs
{
    public class BackgroundJobsConfig
    {
        public string HangfireConnectionStringName { get; set; }
        public string InPaymentFileFolder { get; set; }
    }
}
