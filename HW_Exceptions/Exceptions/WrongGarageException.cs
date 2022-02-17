using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions
{
    internal class WrongGarageException : Exception
    {
        public WrongGarageException()
        {
        }

        public WrongGarageException(string? message) : base(message)
        {
        }

        public WrongGarageException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected WrongGarageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
