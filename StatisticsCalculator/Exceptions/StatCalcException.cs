using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsCalculator.Exceptions
{
    public class StatCalcException : Exception
    {
        public StatCalcException()
        {
        }

        public StatCalcException(string message) : base(message)
        {
        }

        public StatCalcException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StatCalcException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
