using PingTTL.Model.Exceptions;
using System;
using System.Text.RegularExpressions;
namespace PingTTL.Model {
    [Serializable]
    public class Computer {


        private string name;
        private string ip;
        private int timer;


        public string Ip { 
            get { return ip; } 
            set {   if(IsIPAddressValid(value)) {
                        ip = value; } 
                    else {
                        throw new InvalidIPAddressException("Erreur : L'adresse IP est incorrect."); 
                    } 
            } 
        }
        public string Name { get => name;  set => name = value; }
        public int Timer { get => timer; set => timer = value; }

        public Computer(string name, string ip, int timer) { 
            Name = name;
            Ip = ip;
            Timer = timer;
        }

        public bool IsIPAddressValid(string ip) {
            string patternIpAddress = @"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            return Regex.IsMatch(ip,patternIpAddress);
        }
    }
}
