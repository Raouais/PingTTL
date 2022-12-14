using PingTTL.View;
using PingTTL.Model;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading;
using System.Text;
using System;
using System.Diagnostics;

namespace PingTTL {
    public class Task {

        private Computer computer;
        private string status;
        private List<Observer> observers;
        private Ping ping;
        private Thread thread;
        private volatile bool running;
        private Stopwatch stopWatch;
        private string currentStatus;
        private bool isTimeRunning = true;
        public static readonly string INIT = "Non initié";
        public static readonly string WORKING = "Fonctionnelle";
        public static readonly string OUTREACH = "Non Fonctionnelle";

        public Computer Computer { get => computer; set => computer = value; }
        public Stopwatch StopWatch { get => stopWatch; set => stopWatch = value; }

        public Task(Computer computer) {
            Computer = computer;
            status = INIT;
            StopWatch = new Stopwatch();
            StopWatch.Start();
            currentStatus = status;
            ping = new Ping();
            observers = new List<Observer>();
            thread = new Thread(new ThreadStart(StartTask));
            thread.IsBackground = true;
        }

        public void Run() {
            running = true;
            thread.Start();
        }

        public void Stop() {
            if(running) { 
                running = false;
            }
        }

        private void StartTask() {
            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);

            // Wait 1 seconds for a reply.
            int timeout = 1000;

            // Set options for transmission:
            // The data can go through 64 gateways or routers
            // before it is destroyed, and the data packet
            // cannot be fragmented.
            PingOptions options = new PingOptions(64,true);
            while(running) {
                    Thread.Sleep(Computer.Timer * 1000);
                try {
                    PingReply reply = ping.Send(Computer.Ip,timeout,buffer,options);
                    if(reply.Status == IPStatus.Success) {
                        status = WORKING;
                    } else {
                        status = OUTREACH;
                    }
                    if(status != currentStatus || status == OUTREACH) {
                        currentStatus = status;
                        if(isTimeRunning) {
                            stopWatch.Stop();
                            TimeSpan ts = stopWatch.Elapsed;
                            Computer.NonFonctionnalTime += Convert.ToInt32(ts.TotalMilliseconds) / 1000;
                        }
                        if(currentStatus != WORKING) {
                            stopWatch.Restart();
                        }
                        Update();
                    }
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
            observers.ForEach(o => o.Update(Computer,status));
        }
    }
}