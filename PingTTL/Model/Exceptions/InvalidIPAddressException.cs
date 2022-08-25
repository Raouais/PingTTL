using System;

namespace PingTTL.Model.Exceptions {
    internal class InvalidIPAddressException : Exception {

        public InvalidIPAddressException() : base() { }
        public InvalidIPAddressException(string message) : base(message) { }
        public InvalidIPAddressException(string message,Exception inner) : base(message,inner) { }
        protected InvalidIPAddressException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info,context) { }
    }
}
