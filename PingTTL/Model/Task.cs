using PingTTL.View;
using PingTTL.Model;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading;
using System.Text;
using System;

namespace PingTTL {
    public class Task {

        private Computer computer;
        private string status;
        private List<Observer> observers;
        private Ping ping;
        private Thread thread;
        private bool running;
        private string currentStatus;
        public Task(Computer computer) {
            this.computer = computer;
            status = "Non initié";
            currentStatus = status;
            ping = new Ping();
            observers = new List<Observer>();
            thread = new Thread(new ThreadStart(StartTask));
        }

        public void Run() {
            running = true;
            thread.Start();
        }

        public void Stop() {
            running = false;
            thread.Abort();
        }

        private void StartTask() {
            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);

            // Wait 10 seconds for a reply.
            int timeout = 10000;

            // Set options for transmission:
            // The data can go through 64 gateways or routers
            // before it is destroyed, and the data packet
            // cannot be fragmented.
            PingOptions options = new PingOptions(64,true);
            while(running) {
                try {
                    PingReply reply = ping.Send(computer.Ip,timeout,buffer,options);
                    if(reply.Status == IPStatus.Success) {
                        status = "Fonctionnelle";
                    } else {
                        status = "Non Fonctionnelle";
                    }
                    if(status != currentStatus) {
                        currentStatus = status;
                        Update();
                    }
                    Thread.Sleep(computer.Timer * 1000);
                } catch(Exception e) {
                    System.Diagnostics.Debug.WriteLine(e.Message);
                }
            }
        }
        public void Attached(Observer observer) {
            observers.Add(observer);
            Update();
        }

        public void Update() {
            observers.ForEach(o => o.Update(computer,status));
        }
    }
}