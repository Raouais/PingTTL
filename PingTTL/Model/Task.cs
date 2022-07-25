﻿using PingTTL.View;
using PingTTL.Model;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading;
using System.Text;

namespace PingTTL {
    public class Task {

        private Computer computer;
        private string status;
        private List<Observer> observers;
        private Ping ping;
        private Thread thread;
        public Task(Computer computer) {
            this.computer = computer;
            status = "Non initié";
            ping = new Ping();
            observers = new List<Observer>();
            thread = new Thread(new ThreadStart(StartTask));
        }

        public void Run() {
            thread.Start();
        }

        public void Stop() {
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
            while(true) {
                PingReply reply = ping.Send(computer.Ip,timeout,buffer,options);
                if(reply.Status == IPStatus.Success) {
                    status = "Fonctionnelle";
                } else {
                    status = "Non Fonctionnelle";
                }
                Update();
                Thread.Sleep(computer.Timer * 1000);
            }
        }
        public void Attached(MonitoringView observer) {
            observers.Add(observer);
            Update();
        }

        public void Update() {
            observers.ForEach(o => o.Update(computer,status));
        }
    }
}
