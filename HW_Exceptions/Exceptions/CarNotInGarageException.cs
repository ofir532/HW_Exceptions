using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions.Exceptions
{
    internal class CarNotInGarageException : Exception
    {
        public CarNotInGarageException()
        {
        }

        public CarNotInGarageException(string? message) : base(message)
        {
        }

        public CarNotInGarageException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CarNotInGarageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
