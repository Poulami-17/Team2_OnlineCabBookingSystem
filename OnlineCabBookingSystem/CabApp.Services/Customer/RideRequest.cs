using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services
{
    public class RideRequest
    {
        public int CategoryId { get; set; }
        public int CustomerId { get; set; }

        public string PickUp { get; set; }

        public string DropUp { get; set;}


    }
}
