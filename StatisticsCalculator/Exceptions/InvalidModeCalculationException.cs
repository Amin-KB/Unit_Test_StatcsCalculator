using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsCalculator.Exceptions
{
    public class InvalidModeCalculationException : ModeCalculationException
    {
        public InvalidModeCalculationException()
        {
        }

        public InvalidModeCalculationException(string message) : base(message)
        {
        }

        public InvalidModeCalculationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidModeCalculationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
