using CabApp.Data;
using CabApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CabApp.Services.Driver
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
        public async Task<List<Ride>> GetPendingRide()
        {
            return await context.Rides.Where(x => x.RideStatus == RideStatus.Pending).ToListAsync();
        }
    }
}
