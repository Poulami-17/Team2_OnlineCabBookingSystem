﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services
{
    public interface ICustomerPaymentService
    {
        Task<bool> ProcessPayment(string customerId, decimal amount);
      
    }
}
