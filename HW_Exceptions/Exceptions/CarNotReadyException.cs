using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions.Exceptions
{
    internal class CarNotReadyException : Exception
    {
        public CarNotReadyException()
        {
        }

        public CarNotReadyException(string? message) : base(message)
        {
        }

        public CarNotReadyException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CarNotReadyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
