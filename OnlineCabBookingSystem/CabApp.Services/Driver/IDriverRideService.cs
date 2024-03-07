using CabApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services
{
    public interface IDriverRideService
    {
         Task<List<Ride>> GetPendingRide();

         Task<Ride> AcceptRide(int rideId, int driverId);

         Task<Payment> CompleteRide(int rideId);  
    }
}
