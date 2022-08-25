using PingTTL.Model.Exceptions;
using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace PingTTL.Model {
    [Serializable]
    public class Email {

        private string fromMailAddress;
        private string toMailAddress;
        private string password;
        private string subject;
        private int port;
        private string host;
        private bool ssl;

        public string FromMailAddress {
            get { return FromMailAddress1; } 
            set { 
                if(IsEmailAddressValid(value)) { 
                    FromMailAddress1 = value;
                } else {
                    throw new InvalidEmailAddressException("Erreur : L'adresse email 'De' est incorrecte.");
                }
            } 
        }
        public string ToMailAddress {
            get { return ToMailAddress1; }
            set {
                if(IsEmailAddressValid(value)) {
                    ToMailAddress1 = value;
                } else {
                    throw new InvalidEmailAddressException("Erreur : L'adresse email 'Pour' est incorrecte.");
                }
            }
        }
        
        public string Password { get => password; set => password = value; }
        public string FromMailAddress1 { get => fromMailAddress; set => fromMailAddress = value; }
        public string ToMailAddress1 { get => toMailAddress; set => toMailAddress = value; }
        public string Subject { get => subject; set => subject = value; }
        public int Port { get => port; set => port = value; }
        public string Host { get => host; set => host = value; }
        public bool Ssl { get => ssl; set => ssl = value; }

        public Email(string fromMailAddress, string toMailAddress, string subject, bool ssl, int port, string host, string password) {
            FromMailAddress = fromMailAddress;
            ToMailAddress = toMailAddress;
            Password = password;
            Subject = subject;
            Port = port;
            Host = host; 
            Ssl = ssl;
        }

        public bool IsEmailAddressValid(string adr) {
            string patternEmailAddress = "^[A-Za-z0-9.-]+@[A-Za-z0-9]+.[a-zA-Z0-9]*$|^[A-Za-z0-9.-]+@[A-Za-z0-9]+.[a-zA-Z0-9]*\\.[a-zA-Z0-9]*$";
            return Regex.IsMatch(adr,patternEmailAddress);
        }

    }
}