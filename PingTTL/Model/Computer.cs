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
        public string Name {
            get { return name; }
            set {
                if(IsNameLenghOk(value)) {
                    name = value;
                } else {
                    throw new InvalidNameException("Erreur : Le nom de la machine est trop long.");
                }
            }
        }
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

        public bool IsNameLenghOk(string name) {
            int maxNameLengh = 22;
            if(name.Length > maxNameLengh) {
                return false;
            }
            return true;
        }
    }
}
