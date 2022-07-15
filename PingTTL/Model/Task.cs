using PingTTL.View;
using PingTTL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingTTL {
    public class Task {

        private int ttl;
        private Computer computer;
        private string status;
        private List<Observer> observers;
        public Task(Computer computer,int ttl) {
            this.ttl = ttl;
            this.computer = computer;
            this.status = "Non initié";
            this.observers = new List<Observer>();
        }

        public void Attached(MonitoringView observer) {
            this.observers.Add(observer);
        }

        public void UpdateView() {
            this.observers.ForEach(o => o.Update(computer,status));
        }
    }
}
