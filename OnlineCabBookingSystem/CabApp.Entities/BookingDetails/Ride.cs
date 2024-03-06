﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Entities
{
    public class Ride : BaseObject
    {
        [Required]
        public Customer Customer { get; set; }

        [Required]
        public Driver Driver { get; set; }

        [Required]
        public Payment Payment { get; set; }

        [Required]
        [StringLength(200)]
        public string PickupLocation { get; set; }

        [Required]
        [StringLength(200)]
        public string DropOffLocation { get; set; }

        [Required]
        public float Distance { get; set; }

        [Required]
        public RideStatus RideStatus { get; set; }

        //public bool IsCancel { get; set; } = false;??????????
    }
}