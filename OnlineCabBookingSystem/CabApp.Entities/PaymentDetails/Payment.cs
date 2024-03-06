
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
        public float Amount { get; set; }

        [Required]
        public string PaymentMethod { get; set; }

        [Required]
        public string TransactionID { get; set; }

        [Required]
        public bool IsCompleted { get; set; }
        public string CustomerId { get; set; }
    }
}
