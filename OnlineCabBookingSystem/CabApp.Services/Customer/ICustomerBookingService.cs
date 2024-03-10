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
            Task<Ride> BookCab(RideRequest request);
            Task<Ride> GetRiderDetails(int riderId);            
            Task<bool> CancelRide(int customerId, int rideId);

    }
}

