using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsCalculator.Exceptions
{
    public class AverageCalculationException : StatCalcException
    {
        public AverageCalculationException()
        {
        }

        public AverageCalculationException(string message) : base(message)
        {
        }

        public AverageCalculationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AverageCalculationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
