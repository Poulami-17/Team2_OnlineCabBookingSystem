using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services
{
    [Serializable]
    internal class CustomerRideOnGoingException : Exception
    {
        public CustomerRideOnGoingException()
        {
        }

        public CustomerRideOnGoingException(string? message) : base(message)
        {
        }

        public CustomerRideOnGoingException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CustomerRideOnGoingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
 }
