using CabApp.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services
{
    public class NewVehicle
    {
       
        public string VehicleNumber { get; set; }
        public IFormFile VehiclePhoto { get; set; }
        public string Brand { get; set; }
        public string? Color { get; set; }
        public VehicleType VehicleType { get; set; }
        public VehicleCategory Category { get; set; }
    }
}
