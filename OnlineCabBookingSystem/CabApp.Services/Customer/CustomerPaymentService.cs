using CabApp.Data;
using CabApp.Entities;
using CabApp.Services;
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
        //declaring object of dbcontext class
        private readonly CabAppDbContext context;

        //injecting dependency in constructor
        public CustomerPaymentService(CabAppDbContext context)
        {
            this.context = context;
        }

        //customer payment details for the ride
        public async Task<bool> ProcessPayment(PaymentRequest request)
        {
            var ride = await context.Rides.FindAsync(request.RideId);

            if (ride == null)
                throw new Exception("Ride cannot be found");

            if (ride.RideStatus != Entities.RideStatus.Completed)
                throw new Exception("Please mark the ride as completed before payment");


            Payment payment = new Payment();

            payment.PaymentType = request.PaymentType;

            payment.Amount = request.Amount;

            payment.IsCompleted = true;

            ride.Payment = payment;

            context.Rides.Update(ride);
            context.SaveChangesAsync();

            return true;

        }
    }

}
