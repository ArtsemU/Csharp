using System;
using System.Runtime.Serialization;

namespace Lesson10
{
    [Serializable]
    public class InvalidStatusException : Exception
    {
        public InvalidStatusException()
        {
        }

        public InvalidStatusException(string message) : base(message)
        {
        }

        public InvalidStatusException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidStatusException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}