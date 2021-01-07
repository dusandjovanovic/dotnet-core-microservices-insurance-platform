using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentService.Api.Exceptions
{
    public class BussinesExceptions : Exception
    {
        public BussinesExceptions(string message) :
            base(message)
        {
        }

        public BussinesExceptions(string message, Exception ex) :
            base(message, ex)
        {
        }
    }
}
