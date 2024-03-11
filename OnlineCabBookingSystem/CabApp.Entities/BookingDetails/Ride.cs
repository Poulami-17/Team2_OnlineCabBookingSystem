
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CabApp.Entities
{
    public class Ride : BaseObject
    {
        
        public Customer Customer { get; set; }

   
        public Driver? Driver { get; set; }

    
        public Payment? Payment { get; set; }

        [Required]
        [StringLength(200)]
        public string PickUpLocation { get; set; }

        [Required]
        [StringLength(200)]
        public string DropOffLocation { get; set; }

        [Required]
        public float Distance { get; set; } = 0.0f;

        //[Required]
        public RideStatus RideStatus { get; set; }

       
    }
}
