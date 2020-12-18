using System;
using System.Runtime.Serialization;

namespace FinalProject
{
    [Serializable]
    public class InvalidAgeValueException : ApplicationException
    {
        public InvalidAgeValueException()
        {
        }

        public InvalidAgeValueException(string message) : base(message)
        {
        }

        public InvalidAgeValueException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidAgeValueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}