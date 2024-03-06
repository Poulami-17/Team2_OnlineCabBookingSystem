using CabApp.Data;
using CabApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services
{
    internal class AdminVehicleManagerService : IAdminVehicleManager
    {
        // Declaring the object of dbcontext
        private readonly CabAppDbContext _dbContext;

        // Dependency injection in Constructor
        public AdminVehicleManagerService(CabAppDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }

        //Adding a new vehicle 
        public async Task AddNewVehicles(Vehicle vehicle)
        {

            if (_dbContext.Vehicles.Any(d => d.VehicleNumber == vehicle.VehicleNumber))
                throw new AlreadyExistsException("Vehicle already exist");

            await _dbContext.AddAsync(vehicle);
            await _dbContext.SaveChangesAsync();
        }

        //To View all the vehicles 
        public async Task<List<Vehicle>> ViewAllVehicle()
        {
            return await _dbContext.Vehicles.ToListAsync();
        }

        //To view the vehicle by Id
        public async Task<Vehicle> GetVehicleById(int VehicleId)
        {
            return await _dbContext.Vehicles.Where(x => x.ID == VehicleId).SingleAsync();
        }

        //To Delete Vehicles
        public async Task<bool> DeleteVehicle(int VehicleId)
        {
            var vehicle = await _dbContext.Vehicles.FindAsync(VehicleId);

            if (vehicle == null)
            {
                throw new Exception("Employee not found");
            }
            vehicle.DeleteDate = DateTime.Now;
            _dbContext.Vehicles.Update(vehicle);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        //To Modify Vehicle
        public async Task UpdateVehicle(Vehicle updateRequest)
        {
            if (updateRequest == null)
            {
                throw new Exception("Vehicle not found");
            }

            var vehicle = await _dbContext.Vehicles.Where(x => x.ID == updateRequest.ID).SingleAsync();

            vehicle.VehicleNumber = updateRequest.VehicleNumber;
            vehicle.Brand = updateRequest.Brand;
            vehicle.Color = updateRequest.Color;
            vehicle.VehicleType = updateRequest.VehicleType;

            _dbContext.Vehicles.Update(vehicle);
            await _dbContext.SaveChangesAsync();
        }

    }
}
