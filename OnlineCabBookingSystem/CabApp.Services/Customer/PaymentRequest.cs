using CabApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services
{
    public class PaymentRequest
    {
        public int RideId { get; set; }
        public float Amount { get; set; } = 0.0f;
        public PaymentType  PaymentType { get; set; }
    }
}
