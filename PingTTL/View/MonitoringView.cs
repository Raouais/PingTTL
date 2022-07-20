using PingTTL.Model;
using PingTTL.Controller;
using System.Windows.Forms;
using System.Reflection;
using System.Collections.Generic;

namespace PingTTL.View {
    public partial class MonitoringView :Form, Observer {

        
        public MonitoringView() {
            InitializeComponent();
            string filename = "ComputersData.txt";


        }


        public void ShowMonitoring() { }

        public void Update(Computer computer,string status) {
            throw new System.NotImplementedException();
        }

    }
}
