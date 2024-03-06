using CabApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services
{
    public class CustomerPaymentService : ICustomerPaymentService
    {
        private readonly CabAppDbContext context;

        public CustomerPaymentService(CabAppDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> ProcessPayment(int RideId, decimal amount)
        {
            var payment = await context.Payments.FirstOrDefaultAsync(x => x.ID == RideId);

            if (payment != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

}
