using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsCalculator.Exceptions
{
    public class SingleModeNotFoundException : Exception
    {
        public SingleModeNotFoundException()
        {
        }

        public SingleModeNotFoundException(string message) : base(message)
        {
        }

        public SingleModeNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SingleModeNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
