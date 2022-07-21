using PingTTL.Model;
using PingTTL.Controller;
using System.Windows.Forms;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace PingTTL.View {
    public partial class MonitoringView :Form, Observer {

        private readonly int LABELPERCOMPUTER = 3;
        private readonly int nameLabelWidth = 6;
        private readonly int ipLabelWidth = 471;
        private readonly int statusLabelWidth = 829;
        private readonly int initHeightLabel = 164;
        private readonly int incrementHeightView = 30;
        private int currentHeightLabel;

        private List<Computer> computers;
        public MonitoringView() {
            computers = new List<Computer>();
            currentHeightLabel = initHeightLabel;
            InitializeComponent();
        }
    
        public void ShowMonitoring() { }


        public void StopMonitoring() { }


        private void IncreaseView() {
            currentHeightLabel += incrementHeightView;
            ClientSize = new System.Drawing.Size(ClientSize.Width, ClientSize.Height + incrementHeightView);
            monitoring_box.ClientSize = new System.Drawing.Size(monitoring_box.ClientSize.Width,monitoring_box.ClientSize.Height + incrementHeightView);
            quitBtn.Location = new System.Drawing.Point(quitBtn.Location.X, quitBtn.Location.Y + incrementHeightView);
            configBtn.Location = new System.Drawing.Point(configBtn.Location.X, configBtn.Location.Y + incrementHeightView);
        }
        public void createComputerLabels(Computer computer, string status) {
            int[] widths = {nameLabelWidth, ipLabelWidth, statusLabelWidth};
            string[] computerProperties = { computer.Name,computer.Ip,status};

            for(int i = 0; i < LABELPERCOMPUTER; i++) {
                Label label = new Label();
                monitoring_box.Controls.Add(label);
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Ebrima",16.2F);
                label.Name = computerProperties[i];
                label.Location = new System.Drawing.Point(widths[i],currentHeightLabel);
                label.Text = computerProperties[i];
            }
            IncreaseView();
        }

        private bool HasNotComputer(Computer computer) {
            return !computers.Exists(c => c.Ip == computer.Ip);
        }

        private Label GetLabel(string name) {
            return Controls.Find(name,true).FirstOrDefault() as Label;
        }
        
        public void Update(Computer computer,string status) {
            if(HasNotComputer(computer)) {
                createComputerLabels(computer,status);
            } else {
                Label computerLabel = GetLabel(computer.Ip);
                computerLabel.Text = status;
            }
        }

    }
}
