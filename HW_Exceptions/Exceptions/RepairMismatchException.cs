using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace HW_Exceptions.Exceptions
{
    internal class RepairMismatchException :Exception
    {
        public RepairMismatchException()
        {
        }

        public RepairMismatchException(string? message) : base(message)
        {
        }

        public RepairMismatchException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RepairMismatchException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
