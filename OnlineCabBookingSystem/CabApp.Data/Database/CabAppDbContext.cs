using CabApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Data
{
    public class CabAppDbContext: DbContext
    {
        //injecting DbContext Class in Constructor
        public CabAppDbContext(DbContextOptions<CabAppDbContext> options) : base(options) {}


        public  DbSet<Admin> Admins { get; set; }
        public  DbSet<Driver> Drivers { get; set; }
        public  DbSet<Customer> Customers { get; set; }
        public  DbSet<Vehicle> Vehicles { get; set; }
        public  DbSet<VehicleCategory> VehicleCategories { get; set; }
        public  DbSet<Payment> Payments { get; set; }
        public DbSet<Ride> Rides { get; set; }
    }
}
