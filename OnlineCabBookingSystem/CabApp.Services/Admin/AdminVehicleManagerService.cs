using Azure.Storage.Blobs;
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
    public class AdminVehicleManagerService : IAdminVehicleManagerService
    {
        // declare the dbContext Class
        private readonly CabAppDbContext _dbContext;


        //connection string for blob container
        private const string conStr = "BlobEndpoint=https://sprintprojectstorage.blob.core.windows.net/;QueueEndpoint=https://sprintprojectstorage.queue.core.windows.net/;FileEndpoint=https://sprintprojectstorage.file.core.windows.net/;TableEndpoint=https://sprintprojectstorage.table.core.windows.net/;SharedAccessSignature=sv=2022-11-02&ss=bfqt&srt=sco&sp=rwdlacupiytfx&se=2024-03-21T00:49:48Z&st=2024-03-07T16:49:48Z&spr=https,http&sig=bvnn%2FpRS145ZQQQOyECkMkKzUUuK8LQutWmCyxr2kQQ%3D";


        //object of blob container
        private BlobContainerClient blobcontainerClient;
       

        

        // Dependency injection in Constructor
        public AdminVehicleManagerService(CabAppDbContext _dbContext)
        {
            this._dbContext = _dbContext;

            blobcontainerClient = new BlobContainerClient(conStr, "vehicleimage");
        }

        //Adding a new vehicle 
        public async Task AddNewVehicles(NewVehicle addVehicle)
        {

            if (_dbContext.Vehicles.Any(d => d.VehicleNumber == addVehicle.VehicleNumber))
                throw new AlreadyExistsException("Vehicle already exist");

            var vehicle = new Vehicle();

            vehicle.VehicleNumber =addVehicle.VehicleNumber;
            vehicle.Brand = addVehicle.Brand;
            vehicle.Color = addVehicle.Color;
            vehicle.VehicleType = addVehicle.VehicleType;
            vehicle.Category = addVehicle.Category;

            if (addVehicle.VehiclePhoto != null)
            {
                string fileName = Guid.NewGuid() + ".jpg";
                blobcontainerClient.UploadBlob(fileName, addVehicle.VehiclePhoto.OpenReadStream());

                vehicle.VehiclePhoto = "https://sprintprojectstorage.blob.core.windows.net/vehicleimage" + fileName;

            }


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
            return await _dbContext.Vehicles.FirstOrDefaultAsync(x => x.ID == VehicleId);
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

            var vehicle = await _dbContext.Vehicles.FirstOrDefaultAsync(x => x.ID == updateRequest.ID);

            vehicle.VehicleNumber = updateRequest.VehicleNumber;
            vehicle.Brand = updateRequest.Brand;
            vehicle.Color = updateRequest.Color;
            vehicle.VehicleType = updateRequest.VehicleType;

            _dbContext.Vehicles.Update(vehicle);
            await _dbContext.SaveChangesAsync();
        }

    }
}
