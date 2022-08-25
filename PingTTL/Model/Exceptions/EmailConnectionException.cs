using System;
using System.Runtime.Serialization;

namespace PingTTL.Model {
    internal class EmailConnectionException :Exception {
        public EmailConnectionException() {
        }

        public EmailConnectionException(string message) : base(message) {
        }

        public EmailConnectionException(string message,Exception innerException) : base(message,innerException) {
        }

        protected EmailConnectionException(SerializationInfo info,StreamingContext context) : base(info,context) {
        }
    }
}