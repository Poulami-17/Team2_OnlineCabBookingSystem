﻿using CabApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services
{
    public interface IDriverRideService
    {
        public Task<List<Ride>> GetPendingRide();
        
       
    }
}
