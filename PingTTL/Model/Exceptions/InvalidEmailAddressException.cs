using System;

namespace PingTTL.Model.Exceptions {
    internal class InvalidEmailAddressException : Exception{

        public InvalidEmailAddressException() : base() { }
        public InvalidEmailAddressException(string message) : base(message) { }
        public InvalidEmailAddressException(string message,Exception inner) : base(message,inner) { }
        protected InvalidEmailAddressException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info,context) { }
    }
}
