using Azure.Core;
using CabApp.Data;
using CabApp.Entities;
using CabApp.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;
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

        // declare the dbContext
        private readonly CabAppDbContext _dbContext;

        //injecting  the dbcontext using constructor
        public AdminManageDriverService(CabAppDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }

        //Add all the details of a new  Driver
        public async Task AddNewDriversAsync(Driver driver)
        {
            if (_dbContext.Drivers.Any(d => d.AadharNumber == driver.AadharNumber))
                throw new AlreadyExistsException(" Driver already exist");

            await _dbContext.Drivers.AddAsync(driver);
            await _dbContext.SaveChangesAsync();
        }

        //Modify The Driver Details - when admin want to save the changes in driver

        public async Task<Driver> ModifyDriver(Driver driver)

        {
            if (_dbContext.Drivers.Any(d => d.ID != driver.ID))
                throw new NotExistsException("Driver Not Exists");

           _dbContext.Drivers.Update(driver);
            _dbContext.SaveChanges();

            return driver;  
        }

        //Delete The Driver Details

        public async Task<bool> DeleteDriver(int id)
        {
            var driver = await _dbContext.Drivers.FindAsync(id);
            if (driver == null)
            {
                throw new NotExistsException("Driver Not Exists");
            }

            _dbContext.Drivers.Remove(driver);
            await _dbContext.SaveChangesAsync();

            return true;
        }

       
    }
}
