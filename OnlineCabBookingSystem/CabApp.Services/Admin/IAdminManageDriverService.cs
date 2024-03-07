using CabApp.Entities;
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
        public Task AddNewDrivers(NewDriver driver);

        public Task<Driver> ModifyDriver(Driver driver);

        public Task<bool> DeleteDriver(int driverId);

      
    }
}
