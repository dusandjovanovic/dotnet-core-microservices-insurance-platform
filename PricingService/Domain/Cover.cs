using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PricingService.Domain
{
    public class Cover
    {
        public string Code { get; private set; }
        public decimal Price { get; private set; }

        public Cover(string code, decimal price)
        {
            Code = code;
            Price = price;
        }

        public void SetPrice(decimal price)
        {
            Price = price;
        }
    }
}
