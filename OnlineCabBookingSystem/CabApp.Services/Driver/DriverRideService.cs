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


        public async Task<Ride> AcceptRide(int id)
        {
            //driverstatus ??
            return await context.Rides.Where(x => x.ID == id).SingleAsync();
        }

        public async Task<List<Ride>> GetPendingRide()
        {
            return await context.Rides.Where(x => x.RideStatus == RideStatus.Pending).ToListAsync();
        }


        //to be ask from sir?
        public async Task<Payment> RideComplete(int id)
        {
            var currentRide = await context.Rides.Where(x => x.ID == id).SingleAsync();
             
            //var driverStatus ??

            currentRide.RideStatus = RideStatus.Completed;

            await context.SaveChangesAsync();

             return await context.Payments.Where(x=>x.ID == id).SingleAsync();
            

        }
    }
}
