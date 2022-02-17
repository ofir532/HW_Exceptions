using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions.Exceptions
{
    internal class CarAlreadyHereException : Exception
    {
        public CarAlreadyHereException()
        {
        }

        public CarAlreadyHereException(string? message) : base(message)
        {
        }

        public CarAlreadyHereException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CarAlreadyHereException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
