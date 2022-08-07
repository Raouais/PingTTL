using PingTTL.Model;
using PingTTL.Controller;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using PingTTL.Model.Exceptions;
using PingTTL.Mailer;
using System.Threading;

namespace PingTTL.View {
    public partial class ConfigView :Form, Observer {
        private List<Control> mailingControls   = new List<Control>();
        private List<Control> computerControls  = new List<Control>();
        private List<Control> firstStepControls = new List<Control>();
        private Thread loadingThread;
        private bool isStepsNeeded;

        public List<Control> MailingControls { get => mailingControls; set => mailingControls = value; }
        public List<Control> ComputerControls { get => computerControls; set => computerControls = value; }
        public List<Control> FirstStepControls { get => firstStepControls; set => firstStepControls = value; }
        public bool IsStepsNeeded { get => isStepsNeeded; set => isStepsNeeded = value; }

        public ConfigView() {
            InitializeComponent();
        }

        public void AddListComponent() {
            AddcomputerControlsToList();
            AddMailingChildrenToList();
            AddfirstStepControlsToList();
        }
        private void showTemplate(List<Control> list) {
            try {
                config_box.Controls.Clear();
            } catch(NullReferenceException ex) { 
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            list.ForEach(c => AddConfigBoxChildren(c));
        }
        public void ShowFirstStepTemplate() {
            showTemplate(FirstStepControls);
        }

        public void ShowComputerFormTemplate() {
            showTemplate(ComputerControls);
        }

        public void ShowMailingFormTemplate() {
            showTemplate(MailingControls);
        }
        private void AddConfigBoxChildren(Control c) {
            if(c is Button) {
                config_box.Controls.Add((Button) c);
            } else if(c is TextBox) {
                config_box.Controls.Add((TextBox) c);
            } else if(c is Label){
                config_box.Controls.Add((Label) c);
            } else if(c is CheckBox) {
                config_box.Controls.Add((CheckBox) c);
            }
        }
        public void ClearComputerFormTemplate() {
            ComputerControls.ForEach(c => {
                if(c is TextBox) {
                    (c as TextBox).Text = "";
                }
            });
        }

        public void ShowLoading(bool loading) {
            if(loading) {
                loadingThread = null;
                loadingThread = new Thread(new ThreadStart(StartLoading));
                if(config_box.Controls.Contains(error_lbl)) {
                    config_box.Controls.Remove(error_lbl);
                }
                config_box.Controls.Add(loading_lbl);
                config_box.Controls.Remove(email_btn);
                loadingThread.Start();
            } else {
                config_box.Controls.Remove(loading_lbl);
                config_box.Controls.Add(email_btn);
                loadingThread.Abort();
            }
        }
        public void StartLoading() {
            string[] load = {
                "Chargement",
                "Chargement.",
                "Chargement..",
                "Chargement..."
                };
            int count = 0;
            while(true) {
                try {
                    Invoke(new Action(() => loading_lbl.Text = load[count++]));
                } catch(Exception ex) {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
                Thread.Sleep(300);
                count = count >= load.Length ? 0 : count;
            }
        }
        public void ShowError(string text) {
            error_lbl.Text = text;
            config_box.Controls.Add(error_lbl);
        }
        public void HandleStepText(int currentStep, int steps) {
            step_lbl.Text = "Etape : " + currentStep + "/" + steps;
        }
        private void AddMailingChildrenToList() {
            MailingControls.Add(email_btn);
            MailingControls.Add(email_lbl);
            MailingControls.Add(password_input);
            MailingControls.Add(password_lbl);
            MailingControls.Add(host_input);
            MailingControls.Add(host_lbl);
            MailingControls.Add(port_input);
            MailingControls.Add(port_lbl);
            MailingControls.Add(host_lbl);
            MailingControls.Add(subject_input);
            MailingControls.Add(subject_lbl);
            MailingControls.Add(to_input);
            MailingControls.Add(to_lbl);
            MailingControls.Add(from_input);
            MailingControls.Add(from_lbl);
            MailingControls.Add(ssl_box);
            if(IsStepsNeeded) {
                MailingControls.Add(step_lbl);
            }
        }
        private void AddcomputerControlsToList() {

            if(IsStepsNeeded) {
                ComputerControls.Add(step_lbl);
            } else {
                next_btn.Text = "Ajouter";
            }
            ComputerControls.Add(next_btn);
            ComputerControls.Add(ttl_input);
            ComputerControls.Add(ttl_lbl);
            ComputerControls.Add(ip_input);
            ComputerControls.Add(ip_lbl);
            ComputerControls.Add(name_input);
            ComputerControls.Add(name_lbl);
            
        }
        private void AddfirstStepControlsToList() {
            FirstStepControls.Add(nb_computers_input);
            FirstStepControls.Add(nb_computers_lbl);
            FirstStepControls.Add(enter_computers_btn);
        } 
        public void Update(Computer computer,string status) {
            throw new System.NotImplementedException();
        }
    }
}
