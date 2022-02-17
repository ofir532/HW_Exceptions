using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions.Exceptions
{
    internal class TheGarageIsFull : Exception
    {
        public TheGarageIsFull()
        {
        }

        public TheGarageIsFull(string? message) : base(message)
        {
        }

        public TheGarageIsFull(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TheGarageIsFull(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
