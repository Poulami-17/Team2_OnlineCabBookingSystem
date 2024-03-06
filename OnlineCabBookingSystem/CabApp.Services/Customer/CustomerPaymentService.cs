using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services
{
    public class CustomerPaymentService : ICustomerPaymentService
    {
        public async Task<bool> ProcessPayment(string customerId, decimal amount)
        {

            return await Task.FromResult(true);
        }
       
    }
}
