﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentService.Api.Exceptions
{
    public class BankStatementsFileNotFound : BussinesExceptions
    {
        public BankStatementsFileNotFound(Exception ex) :
            base("Bank statements file not found.", ex)
        {
        }
    }
}
