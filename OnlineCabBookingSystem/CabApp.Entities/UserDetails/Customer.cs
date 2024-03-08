using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Entities
{
    public class Customer : User
    {

        [Required]
        [StringLength(100)]
        public string? Address { get; set; }

        [Required]
        public float? AverageRating { get; set; } = 0.0f;
    }
}
