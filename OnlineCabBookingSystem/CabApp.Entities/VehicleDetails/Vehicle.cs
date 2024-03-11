
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Entities
{
    public class Vehicle : BaseObject
    {
        [Required]
        public string VehicleNumber { get; set; }

        [Required]
        public string VehiclePhoto { get; set;}

        [Required]
        public string Brand { get; set; }

        [Required]
        public string? Color { get; set; }

        [Required]
        public VehicleType? VehicleType { get; set; }

        [Required]
        public VehicleCategory Category { get; set; }

    }
}
