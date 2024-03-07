using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CabApp.Entities;

namespace CabApp.Services
{
    public interface ICustomerBookingService
    {

        public interface ICustomerBookingService
        {
            Task<Ride> BookCab(int Id);
            Task<Driver> GetDriverDetails(int driverId);
            Task<bool> CancelBooking(int Id);

        }
    }
}

