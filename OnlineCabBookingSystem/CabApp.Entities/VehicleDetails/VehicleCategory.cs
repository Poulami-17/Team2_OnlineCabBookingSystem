
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Entities
{
    public class VehicleCategory : BaseObject
    {
        [Required]
        public string Title { get; set; }

        [StringLength(50)]
        public string? Description { get; set; }
        [Required]
        public float PerKmCharge { get; set; }
    }
}
