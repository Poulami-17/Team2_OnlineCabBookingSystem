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
        [RegularExpression("[A-Z]{4} [0-9]{4}", ErrorMessage = "Invalid PanNo")]
        public string PanNumber { get; set; }

        [Required]
        [RegularExpression("[A-Z]{4} [0-9]{4}", ErrorMessage = "Invalid AadharNo")]
        public long AadharNumber { get; set; }

        [Required]
        public string VehicleId { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]{2}\d{2} [A-Z]{2}\d{4}$", ErrorMessage = "Invalid license number format")]
        public string LicenseNumber { get; set; }


        [Required]
        [RegularExpression("^(Free|Busy)$", ErrorMessage = "Status must be one of: Free and Busy")]
        public int TotalTrips { get; set; }

        [Required]
        public float AverageRating { get; set; }

        [Required]
        public bool AvailabilityStatus { get; set; }

    }
}
