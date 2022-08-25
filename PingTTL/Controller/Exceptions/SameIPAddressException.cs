using System;
namespace PingTTL.Controller {
    [Serializable]
    internal class SameIPAddressException : Exception{
        public SameIPAddressException() : base() { }
        public SameIPAddressException(string message) : base(message) { }
        public SameIPAddressException(string message,Exception inner) : base(message,inner) { }
        protected SameIPAddressException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info,context) { }
    }
}
