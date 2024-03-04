using CabApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Data
{
    public class CabAppDBContext: DbContext
    {
        public CabAppDBContext(DbContextOptions<CabAppDBContext> options) : base(options) 
        {

        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<VehicleCategory> VehicleCategories { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Ride> Rides { get; set; }
    }
}
