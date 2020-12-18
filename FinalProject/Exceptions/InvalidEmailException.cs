using System;
using System.Runtime.Serialization;

namespace FinalProject
{
    [Serializable]
    internal class InvalidEmailException : Exception
    {
        public InvalidEmailException()
        {
        }

        public InvalidEmailException(string message) : base(message)
        {
        }

        public InvalidEmailException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidEmailException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}