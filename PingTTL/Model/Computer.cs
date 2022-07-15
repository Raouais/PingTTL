using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingTTL.Model {
    [Serializable]
    public class Computer {

        public string Name { get; set; }
        public String Ip { get; set; }
        public int Timer { get; set; }

        public Computer(string name, string ip, int timer) { 
            this.Name = name;
            this.Ip = ip;
            this.Timer = timer;
        }
    }
}
