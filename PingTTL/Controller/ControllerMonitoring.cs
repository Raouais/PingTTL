using PingTTL.Model;
using PingTTL.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PingTTL.Controller {
    public class ControllerMonitoring {


        private static ControllerMonitoring instance;
        private List<Computer> computers;
        private List<Task> tasks;
        private MonitoringView view;
        private Email email;
        private PingTTL.Mailer.Mailer mailer;
        public MonitoringView View { get => view; set => view = value; }
        public List<Computer> Computers { get => computers; set => computers = value; }
        public List<Task> Tasks { get => tasks; set => tasks = value; }
        public Email Email { get => email; set => email = value; }

        public ControllerMonitoring() {
            Tasks = new List<Task>();
            Computers = new List<Computer>();
            createView();
        }
        public void createView() {
            View = new MonitoringView();
            View.FormClosed += new FormClosedEventHandler(CloseConfigView);
            View.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            View.quitBtn.Click += new System.EventHandler(this.CloseConfigView);
            View.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            View.edit_email_btn.Click += new System.EventHandler(this.edit_email_btn_Click);
        }
        private void edit_email_btn_Click(object sender,EventArgs e) {
            ControllerConfig conf = ControllerConfig.getInstance();
            conf.createView();
            conf.AddEmail();
            View.FormClosed -= new FormClosedEventHandler(CloseConfigView);
            View.Close();
            createView();
        }
        private void add_btn_Click(object sender,EventArgs e) { 
            ControllerConfig conf = ControllerConfig.getInstance();
            conf.createView();
            conf.AddComputer();
            View.FormClosed -= new FormClosedEventHandler(CloseConfigView);
            View.Close();
            createView();
        }

        private void reset_btn_Click(object sender,EventArgs e) {
            ControllerConfig conf = ControllerConfig.getInstance();
            StopTasks();
            View.FormClosed -= new FormClosedEventHandler(CloseConfigView);
            View.Close();
            createView();
            conf.Reset();
            conf.createView();
            conf.IsConfiguring = true;
            conf.View.IsStepsNeeded = true;
            conf.View.AddListComponent();
            conf.View.ShowFirstStepTemplate();
            conf.View.Show();
        }

        private void StopTasks() {
            Tasks.ForEach(task => task.Stop());
        }

        private void CloseConfigView(object sender,EventArgs e) {
            StopTasks();
            Application.Exit();
        }

        public static ControllerMonitoring getInstance() {
            if(instance == null) {
                instance = new ControllerMonitoring();
            }
            return instance;
        }
        public void AddComputer(List<Computer> computers) {
            Computers = computers;
        }
        public void StartMonitoring() {
            mailer = new Mailer.Mailer(Email);
            Computers.ForEach(c => {
                Task t = new Task(c);
                t.Attached(View);
                t.Attached(mailer);
                Tasks.Add(t);
                t.Run();
            });
        }
    }
}
