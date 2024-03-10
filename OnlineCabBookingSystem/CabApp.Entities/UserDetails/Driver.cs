using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Entities
{
    public class Driver : User
    {
        [Required]
        public string DriverPhoto { get; set; }

        [Required]  
        public string Gender { get; set; }


        [Required]
        [RegularExpression("[A-Z]{4} [0-9]{4}", ErrorMessage = "Invalid AadharNo")]
        public long AadharNumber { get; set; }
       
        [Required]
        [RegularExpression(@"^[A-Z]{2}\d{2} [A-Z]{2}\d{4}$", ErrorMessage = "Invalid license number format")]
        public string LicenseNumber { get; set; }

        [Required]
        public string LicenceCertificatePdf { get; set; }

        
        public float? AverageRating { get; set; } = 0.0f;

        [Required]
        public bool AvailabilityStatus { get; set; }

        [Required]
        public Vehicle Vehicle { get; set; }

      

    }
}
