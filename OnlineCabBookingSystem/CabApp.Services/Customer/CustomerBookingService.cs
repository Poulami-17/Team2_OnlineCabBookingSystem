using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CabApp.Data;
using CabApp.Entities;

namespace CabApp.Services
{
    public class CustomerBookingService:ICustomerBookingService
    {
        private readonly CabAppDbContext context;

        private readonly List<Ride> _bookings = new List<Ride>();

        private readonly List<Driver> _drivers = new List<Driver>();


        //constructor Dependency injection
        public CustomerBookingService(CabAppDbContext context)
        {
            this.context = context;
        }



        public async Task<Ride> BookCab(int customerId, Ride booking)
        {
            booking.ID = customerId;
            _bookings.Add(booking);

            return await Task.FromResult(booking);
        }

        public async Task<Driver> GetDriverDetails(int driverId)
        {
            return await Task.FromResult(_drivers.FirstOrDefault(d => d.ID == driverId));
        }


        public async Task<bool> CancelBooking(int customerId, int bookingId)
        {
            var booking = _bookings.FirstOrDefault(b => b.ID == bookingId && b.ID == customerId);
            if (booking != null)
            {
                _bookings.Remove(booking);
                return await Task.FromResult(true);
            }
            return await Task.FromResult(false);
        }
    }
}
