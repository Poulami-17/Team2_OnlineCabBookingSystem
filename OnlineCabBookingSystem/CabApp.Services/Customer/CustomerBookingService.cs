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



        public async Task<Ride> BookCab(RideRequest request)
        {
            if (context.Rides.Any(d => d.Customer.ID == request.CustomerId && d.RideStatus != RideStatus.Completed))
                throw new CustomerRideOnGoingException("Customer already has a ongoing ride");

            var customer = context.Customers.Find(request.CustomerId);
            var category = context.VehicleCategories.Find(request.CategoryId);

            //pending and accepted condition
            Ride r = new Ride();
            r.RideStatus = RideStatus.Pending;
            r.Customer = customer;



            context.Rides.Add(r);
            await context.SaveChangesAsync();

            return r;
        }
        public async Task<bool> AcceptBooking(int bookingId, int RideId)
        {
            // var booking = context.Rides.FindAsync(bookingId);

            var booking = context.Rides.FirstOrDefault(b => b.ID == bookingId && b.ID == RideId);
            if (booking != null && booking.RideStatus == RideStatus.Pending)

            {
                booking.RideStatus = RideStatus.Accepted;
                context.Rides.Update(booking);

                await context.SaveChangesAsync();

                return true;
            }
            return false;
        }


        public async Task<Ride> GetRiderDetails(int riderId)
        {
            var ride = await context.Rides.Include(d => d.Driver).FirstOrDefaultAsync(d => d.ID == riderId);
            return ride;
        }


        public async Task<bool> CancelBooking(int customerId, int bookingId)
        {
            var booking = context.Rides.FirstOrDefault(b => b.ID == bookingId && b.ID == customerId);
            if (booking != null)
            {
                booking.RideStatus = RideStatus.Cancelled;
                context.Rides.Update(booking);

                await context.SaveChangesAsync();

                return true;
            }
            return false;
        }
    }
}
