using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services.Exceptions
{
    public class DuplicateRideException : Exception
    {
        public DuplicateRideException()
        {
        }

        public DuplicateRideException(string? message) : base(message)
        {
        }

        public DuplicateRideException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DuplicateRideException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
