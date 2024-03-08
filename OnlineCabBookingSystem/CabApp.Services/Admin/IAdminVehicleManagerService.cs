using CabApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services
{
    public interface IAdminVehicleManagerService
    {
        Task<Vehicle> AddNewVehicles(NewVehicle addVehicle);
        Task<List<Vehicle>> ViewAllVehicle();
        Task<Vehicle> GetVehicleById(int VehicleNumber);
        Task<Vehicle> UpdateVehicle(Vehicle updateRequest);
        Task<bool> DeleteVehicle(int VehicleId);
    }
}
