using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Entities
{
    public enum RideStatus
    {
        Pending = -1,
        Accepted = 0,
        Started = 1,
        Ongoing = 2,
        Completed = 3,
        Cancelled = -1
    }
}
