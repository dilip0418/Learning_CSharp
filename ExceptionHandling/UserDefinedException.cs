using System;
using System.Runtime.Serialization;

namespace ExceptionHandling
{
    [Serializable] //annotating the class as Serializable to use serialization
    class UserDefinedException : Exception
    {
        public UserDefinedException() : base() { }
        public UserDefinedException(string Message) : base(Message) { }
        public UserDefinedException(string Message, Exception innerException) : base(Message, innerException) { }

        //This constructor is used to tarnsfer the exception object over different application domains
        public UserDefinedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
