using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Entities
{
    public enum RideStatus
    {
        Pending = 0,
        Accepted = 1,
        Started = 2,
        Ongoing = 3,
        Completed = 4,
        Cancelled = 5
    }
}
