using PingTTL.Model.Exceptions;
using System;
using System.Text.RegularExpressions;
namespace PingTTL.Model {
    [Serializable]
    public class Computer {


        private string name;
        private int ip;
        private int port;


        public string Name { get; set; }
        public String Ip { 
            get { return name; } 
            set {   if(IsIPAddressValid(value)) {
                        name = value; } 
                    else {
                        throw new InvalidIPAddressException("Erreur : L'adresse IP est incorrect."); 
                    } 
            } 
        }
        public int Timer { get; set; }

        public Computer(string name, string ip, int timer) { 
            this.Name = name;
            this.Ip = ip;
            this.Timer = timer;
        }

        public bool IsIPAddressValid(string ip) {
            string patternIpAddress = @"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            return Regex.IsMatch(ip,patternIpAddress);
        }
    }
}
