﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services.Exceptions
{
    public class NotExistsException : Exception
    {
        public NotExistsException()
        {
        }

        public NotExistsException(string? message) : base(message)
        {
        }

        public NotExistsException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NotExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
