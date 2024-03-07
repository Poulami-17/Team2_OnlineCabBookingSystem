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
            Task<Ride> BookCab(int rideId);
            Task<Driver> GetDriverDetails(int driverId);
            Task<bool> CancelRide(int rideId);

        }
    }
}

