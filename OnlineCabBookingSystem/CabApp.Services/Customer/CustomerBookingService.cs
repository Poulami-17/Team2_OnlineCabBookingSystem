using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CabApp.Data;
using CabApp.Entities;
using CabApp.Services;
using CabApp.Services.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace CabApp.Services
{
    public class CustomerBookingService : ICustomerBookingService
    {
        private readonly CabAppDbContext context;
        //   private int customerId;


        //constructor Dependency injection
        public CustomerBookingService(CabAppDbContext context)
        {
            this.context = context;
        }


        //it will book a new ride
        public async Task<Ride> BookCab(RideRequest request)
        {
            if (context.Rides.Any(d => d.Customer.ID == request.CustomerId && d.RideStatus == RideStatus.Ongoing))
                throw new CustomerRideOnGoingException("Customer already has a ongoing ride");

            var customer = context.Customers.Find(request.CustomerId);
            
            var vehicleCategory = context.VehicleCategories.Find(request.VehicleCategoryId);

           

            
            Ride ride = new Ride();

            ride.RideStatus = RideStatus.Pending;
            ride.Customer = customer;
            ride.PickUpLocation = request.PickUp;
            ride.DropOffLocation = request.DropUp;
            ride.Distance = request.Distance;
            ride.CreateDate = DateTime.Now;

            ride.Payment = new Payment();

            ride.Payment.PaymentType = PaymentType.Cash;
            ride.Payment.Amount = request.Distance * vehicleCategory.PerKmCharge;



            context.Rides.Add(ride);
            await context.SaveChangesAsync();

            return ride;
        }

      
        //customer will able to see driver details
        public async Task<Ride> GetRiderDetails(int riderId)
        {
             var ride = await context.Rides.Include(d => d.Driver).FirstOrDefaultAsync(d => d.ID == riderId);

            return ride;
        }


        //customer can cancel his ride
        public async Task<bool> CancelRide(int customerId, int rideId)
        {
            var ride =  context.Rides.FirstOrDefault(b => b.ID == rideId && b.Customer.ID == customerId);

            if (ride.RideStatus.Equals(RideStatus.Accepted)|| ride.RideStatus.Equals(RideStatus.Pending))
            {
                ride.RideStatus = RideStatus.Cancelled;

                context.Rides.Update(ride);

                await context.SaveChangesAsync();

                return true;
            }
            return false;
        }

        
    }
}
