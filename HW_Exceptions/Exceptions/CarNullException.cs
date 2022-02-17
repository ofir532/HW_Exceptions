using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions.Exceptions
{
    internal class CarNullException : Exception
    {
        public CarNullException()
        {
        }

        public CarNullException(string? message) : base(message)
        {
        }

        public CarNullException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CarNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
