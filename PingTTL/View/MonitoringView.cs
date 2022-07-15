using PingTTL.Model;
using PingTTL.Controller;
using System.Windows.Forms;
using System.Reflection;
using System.Collections.Generic;

namespace PingTTL.View {
    public partial class MonitoringView :Form, Observer {

        private ControllerTask controller;
        
        public MonitoringView(ControllerTask controller) {
            this.controller = controller;
            InitializeComponent();
            string filename = "ComputersData.txt";

            List<Computer> computers = new List<Computer>() {
                new Computer("PC1","ip",5),
                new Computer("PC2","ip",6)

            };
            System.Diagnostics.Debug.WriteLine(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));

            Utils.WriteToBinaryFile(filename,computers,true);
            System.Diagnostics.Debug.WriteLine((Utils.ReadFromBinaryFile<List<Computer>>(filename)).Count);
        }

        public void Update(Computer computer,string status) {
            throw new System.NotImplementedException();
        }

    }
}
