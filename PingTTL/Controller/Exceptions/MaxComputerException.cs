using System;
using System.Runtime.Serialization;

namespace PingTTL.Controller {
    [Serializable]
    internal class MaxComputerException :Exception {
        public MaxComputerException() {
        }

        public MaxComputerException(string message) : base(message) {
        }

        public MaxComputerException(string message,Exception innerException) : base(message,innerException) {
        }

        protected MaxComputerException(SerializationInfo info,StreamingContext context) : base(info,context) {
        }
    }
}