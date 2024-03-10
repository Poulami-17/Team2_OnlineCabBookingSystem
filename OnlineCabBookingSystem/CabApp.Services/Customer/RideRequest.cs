using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services
{
    public class RideRequest
    {
        public int CustomerId { get; set; }

        public string PickUp { get; set; }

        public string DropUp { get; set;}

        public int VehicleCategoryId {  get; set; }
        public float Distance { get; set; }


    }
}
