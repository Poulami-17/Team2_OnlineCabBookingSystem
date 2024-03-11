using CabApp.Entities;
using CabApp.Services.Admin;

//using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services
{
    public interface IAdminManageDriverService
    {
        public Task<Driver> AddNewDrivers(NewDriver driver);

        public Task<Driver> ModifyDriver(ModifyDriver driver);

        public Task<bool> DeleteDriver(int driverId);

      
    }
}
