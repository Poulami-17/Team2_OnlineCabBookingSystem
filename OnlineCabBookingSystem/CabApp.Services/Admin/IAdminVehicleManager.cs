using CabApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services
{
    internal interface IAdminVehicleManager
    {
        Task AddNewVehicles(Vehicle vehicle);
        Task<List<Vehicle>> ViewAllVehicle();
        Task<Vehicle> GetVehicleById(int VehicleNumber);
        Task UpdateVehicle(Vehicle updateRequest);
        Task<bool> DeleteVehicle(int VehicleId);
    }
}
