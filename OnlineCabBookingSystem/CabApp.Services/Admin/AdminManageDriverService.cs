using Azure.Core;
using Azure.Storage.Blobs;
using CabApp.Data;
using CabApp.Entities;
using CabApp.Services.Admin;
using CabApp.Services.Exceptions;
//using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services
{
    public class AdminManageDriverService : IAdminManageDriverService
    {

        // declare the dbContext Class
        private readonly CabAppDbContext _dbContext;


        //connection string for blob container
        private const string conStr = "BlobEndpoint=https://sprintprojectstorage.blob.core.windows.net/;QueueEndpoint=https://sprintprojectstorage.queue.core.windows.net/;FileEndpoint=https://sprintprojectstorage.file.core.windows.net/;TableEndpoint=https://sprintprojectstorage.table.core.windows.net/;SharedAccessSignature=sv=2022-11-02&ss=bfqt&srt=sco&sp=rwdlacupiytfx&se=2024-03-21T00:49:48Z&st=2024-03-07T16:49:48Z&spr=https,http&sig=bvnn%2FpRS145ZQQQOyECkMkKzUUuK8LQutWmCyxr2kQQ%3D";


        //object of blob container
        private BlobContainerClient blobcontainerClient1;
        private BlobContainerClient blobcontainerClient2;


        //injecting  the dbcontext using constructor
        public AdminManageDriverService(CabAppDbContext _dbContext)
        {
            this._dbContext = _dbContext;

            
            blobcontainerClient1 = new BlobContainerClient(conStr, "driverprofilephoto");

            blobcontainerClient2 = new BlobContainerClient(conStr, "driverlicencepdf");
        }

        //Add all the details of a new Driver
        public async Task<Driver> AddNewDrivers(NewDriver driver)
        {
            if (_dbContext.Drivers.Any(d => d.AadharNumber == driver.AadharNumber))
                throw new AlreadyExistsException(" Driver already exist");


            var addDriver = new Driver();

            addDriver.LicenseNumber = driver.LicenseNumber;
            addDriver.Password = driver.Password;
            addDriver.Name = driver.Name;
            addDriver.Gender = driver.Gender;
            addDriver.Email = driver.Email;
            addDriver.UserName = driver.UserName;
            addDriver.AadharNumber = driver.AadharNumber;
            addDriver.PhoneNumber = driver.PhoneNumber;
            addDriver.CreateDate = DateTime.Now;
            addDriver.Vehicle = _dbContext.Vehicles.Find(driver.VehicleId);
            addDriver.AvailabilityStatus = false;

            if (driver.DriverPhoto != null)
            {
                string fileName = Guid.NewGuid() + ".jpg";
                blobcontainerClient1.UploadBlob(fileName, driver.DriverPhoto.OpenReadStream());

                addDriver.DriverPhoto = "https://sprintprojectstorage.blob.core.windows.net/driverprofilephoto" + fileName;

            }

            if (driver.LicenceCertificatePdf != null)
            {
                string fileName = Guid.NewGuid() + ".pdf";
                blobcontainerClient2.UploadBlob(fileName, driver.LicenceCertificatePdf.OpenReadStream());

                addDriver.LicenceCertificatePdf = "https://sprintprojectstorage.blob.core.windows.net/driverlicencepdf" + fileName;

            }



             await _dbContext.Drivers.AddAsync(addDriver);
            await _dbContext.SaveChangesAsync();

            return addDriver;
        }


        //Modify The Driver Details - when admin want to save the changes in driver
        public async Task<Driver> ModifyDriver(ModifyDriver driver)

        
        {
            if (!_dbContext.Drivers.Any(d => d.ID == driver.DriverId))
                throw new NotExistsException("Driver Not Exists");


            
           var updateDriver = await _dbContext.Drivers.FirstOrDefaultAsync(x => x.ID == driver.DriverId);

           

            updateDriver.Name = driver.Name;

            updateDriver.Email = driver.Email;

            updateDriver.Password = driver.Password;

            updateDriver.PhoneNumber = driver.PhoneNumber;

            updateDriver.Vehicle = _dbContext.Vehicles.Find(driver.VehicleId);






            _dbContext.Drivers.Update(updateDriver);
            _dbContext.SaveChanges();

            return updateDriver;  
        }

        //Delete The Driver Details

        public async Task<bool> DeleteDriver(int driverId)
        {
            var driver = await _dbContext.Drivers.FindAsync(driverId);
            

            if (driver == null)
            {
                throw new NotExistsException("Driver Not Exists");
            }
            driver.DeleteDate = DateTime.Now;

            _dbContext.Drivers.Update(driver);
            await _dbContext.SaveChangesAsync();

            return true;
        }

       
    }
}
