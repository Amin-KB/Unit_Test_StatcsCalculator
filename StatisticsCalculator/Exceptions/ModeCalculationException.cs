using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsCalculator.Exceptions
{
    public class ModeCalculationException : StatCalcException
    {
        public ModeCalculationException()
        {
        }

        public ModeCalculationException(string message) : base(message)
        {
        }

        public ModeCalculationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModeCalculationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
