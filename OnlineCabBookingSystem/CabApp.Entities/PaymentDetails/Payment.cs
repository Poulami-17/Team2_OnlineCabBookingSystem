﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Entities
{
    public class Payment : BaseObject
    {
        [Required]
        public float Amount { get; set; } = 0.0f; 

        [Required]
        public PaymentType? PaymentType { get; set; }

        public string? TransactionID { get; set; }

        [Required]
        public bool IsCompleted { get; set; }

       
    }
}
