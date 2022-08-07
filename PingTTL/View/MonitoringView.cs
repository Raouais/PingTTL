using PingTTL.Model;
using PingTTL.Controller;
using System.Windows.Forms;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System;

namespace PingTTL.View {
    public partial class MonitoringView :Form, Observer {

        private readonly int LABELPERCOMPUTER = 3;

        private readonly int nameLabelPosX = 6;
        private readonly int ipLabelPosX = 468;
        private readonly int statusLabelPosX = 722;

        private readonly int initLabelPoxY = 164;

        private readonly int incrementHeightView = 30;
        private int currentLabelPosY;

        private List<Computer> computers;
        public MonitoringView() {
            computers = new List<Computer>();
            currentLabelPosY = initLabelPoxY;
            InitializeComponent();
        }

        public void Clear() {
            monitoring_box.Controls.Clear();
        }

        private void IncreaseView() {
            currentLabelPosY += incrementHeightView;
            ClientSize = new System.Drawing.Size(ClientSize.Width, ClientSize.Height + incrementHeightView);
            monitoring_box.ClientSize = new System.Drawing.Size(monitoring_box.ClientSize.Width,monitoring_box.ClientSize.Height + incrementHeightView);
            quitBtn.Location = new System.Drawing.Point(quitBtn.Location.X, quitBtn.Location.Y + incrementHeightView);
            add_btn.Location = new System.Drawing.Point(add_btn.Location.X, add_btn.Location.Y + incrementHeightView);
            config_lbl.Location = new System.Drawing.Point(config_lbl.Location.X,config_lbl.Location.Y + incrementHeightView);
            edit_email_btn.Location = new System.Drawing.Point(edit_email_btn.Location.X,edit_email_btn.Location.Y + incrementHeightView);
        }
        public void createComputerLabels(Computer computer, string status) {
            int[] widths = {nameLabelPosX, ipLabelPosX, statusLabelPosX};
            string[] computerProperties = { computer.Name,computer.Ip,status};

            for(int i = 0; i < LABELPERCOMPUTER; i++) {
                Label label = new Label();
                monitoring_box.Controls.Add(label);
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Ebrima",16.2F);
                if(i == 2) {
                    label.Name = computerProperties[i - 1];
                } else {
                    label.Name = computer.Name;
                }
                
                label.Location = new System.Drawing.Point(widths[i],currentLabelPosY);
                label.Text = computerProperties[i];
            }
            IncreaseView();
        }

        public void RemoveComputer(Computer computer) {

        }

        private bool HasNotComputer(Computer computer) {
            return !computers.Exists(c => c.Equals(computer));
        }

        private Label GetLabelByName(string name) {
            return Controls.Find(name,true).FirstOrDefault() as Label;
        }
        
        public void Update(Computer computer,string status) {
            if(HasNotComputer(computer)) {
                createComputerLabels(computer,status);
                computers.Add(computer);
            } else {
                Label computerLabel = GetLabelByName(computer.Ip);
                try {
                    Invoke(new Action(() => computerLabel.Text = status));
                } catch(Exception ex) {
                    System.Diagnostics.Debug.WriteLine(ex.Message);    
                }
            }
        }

    }
}
