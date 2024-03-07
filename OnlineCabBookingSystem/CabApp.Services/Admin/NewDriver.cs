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
    public class NewDriver
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public long PhoneNumber { get; set; }
        public long AadharNumber { get; set; }
        public string LicenseNumber { get; set; }
        public IFormFile DriverPhoto { get; set; }
        public IFormFile LicenceCertificatePdf { get; set; }
    
    }
}
