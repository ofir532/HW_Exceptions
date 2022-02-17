using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions.Exceptions
{
    internal class WeDoNotFixTotalLostException : Exception
    {
        public WeDoNotFixTotalLostException()
        {
        }

        public WeDoNotFixTotalLostException(string? message) : base(message)
        {
        }

        public WeDoNotFixTotalLostException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected WeDoNotFixTotalLostException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
