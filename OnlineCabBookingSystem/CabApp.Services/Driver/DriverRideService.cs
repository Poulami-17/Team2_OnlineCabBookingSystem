using CabApp.Data;
using CabApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Azure.Core;

namespace CabApp.Services
{
    public class DriverRideService : IDriverRideService
    {
        //object of db context class
        private readonly CabAppDbContext context;


        //constructor Dependency injection
        public DriverRideService(CabAppDbContext context)
        {
            this.context = context;
        }


        //driver will able to see the rides available
        public async Task<List<Ride>> GetPendingRide()
        {
            return await context.Rides.Where(x => x.RideStatus == RideStatus.Pending).ToListAsync();
        }


        //When driver accept the ride ,it will send back ride id and will get that ride details
        public async Task<Ride> AcceptRide(int id,int driverId)
        {
            var acceptedRide = await context.Rides.Where(x => x.ID == id).SingleAsync();


            acceptedRide.Driver.AvailabilityStatus = false;
            acceptedRide.RideStatus = RideStatus.Accepted;

            acceptedRide.Driver = await context.Drivers.Where(x=>x.ID==driverId).SingleAsync();

            context.Rides.Update(acceptedRide);
            await context.SaveChangesAsync();

            return await context.Rides.Where(x => x.ID == id).SingleAsync();
        }

        


        //When driver click on complete ride button,then ride status will change and he will able to see the payment details
       
        public async Task<Payment> RideComplete(int id)
        {
            var currentRide = await context.Rides.Where(x => x.ID == id).SingleAsync();

            currentRide.Driver.AvailabilityStatus = true;

            currentRide.RideStatus = RideStatus.Completed;

            context.Rides.Update(currentRide);
            await context.SaveChangesAsync();

            return await context.Payments.Where(x=>x.ID == id).SingleAsync();
            

        }
    }
}
