using PingTTL.Model;
using PingTTL.Controller;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using PingTTL.Model.Exceptions;

namespace PingTTL.View {
    public partial class ConfigView :Form, Observer {

        private ControllerConfig controller;
        private int steps = 1;
        private int currentStep = 1;
        private List<Control> MailingControls   = new List<Control>();
        private List<Control> ComputerControls  = new List<Control>();
        private List<Control> FirstStepControls = new List<Control>();
         
        public ConfigView(ControllerConfig controller) {
            this.controller = controller;
            InitializeComponent();
            AddComputerControlsToList();
            AddMailingChildrenToList();
            AddFirstStepControlsToList();
        }

        private void enter_computers_btn_Click(object sender, EventArgs e) {
            steps += Utils.GetIntFromString(nb_computers_input.Text);
            System.Diagnostics.Debug.WriteLine(steps);
            if(steps > 0 && steps <= controller.MaxSteps) {
                ShowComputerFormTemplate();
                HandleStepText();
            } else {
                ShowError("Erreur : Veuillez insérer un chiffre compris entre les bornes.");
                steps = 1;
            }
        }

        private void email_btn_Click(object sender, EventArgs e) {
            bool isNotEmptyText = true;
            MailingControls.ForEach(c => {
                if(c is TextBox && (c as TextBox).Text == "") {
                    isNotEmptyText = false;
                }
            });
            if(isNotEmptyText) {
                if(Utils.GetIntFromString(port_input.Text) > 0) {
                    try {
                       /* controller.AddMail*/
                    }
                }
            } else {
                ShowError("Erreur : Tout les champs sont requis");
            }
        }

        private void next_btn_Click(object sender, EventArgs e) {
            if(name_input.Text != "" && ip_input.Text != "" && ttl_input.Text != "") {
                int ttl = Utils.GetIntFromString(ttl_input.Text);
                if(ttl > 0) {
                    try {
                        controller.AddComputer(new Computer(name_input.Text,ip_input.Text,ttl));
                        ClearComputerFormTemplate();
                        currentStep++;
                        HandleStepText();
                    } catch(SameIPAddressException es) {
                        ShowError(es.Message);
                    } catch(InvalidIPAddressException ei) {
                        ShowError(ei.Message);
                    }
                } else {
                    ShowError("Erreur : Le champs '" + ttl_lbl.Text + "' doit contenir que des chiffres.");
                } 
            } else {
                ShowError("Erreur : Tout les champs sont requis");
            }
            if(currentStep == steps) {
                /*controller.StoreComputersList();*/
                ShowMailingFormTemplate();
                HandleStepText();
            }
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
            } else {
                config_box.Controls.Add((Label) c);
            }
        }


        private void ClearComputerFormTemplate() {
            ComputerControls.ForEach(c => {
                if(c is TextBox) {
                    (c as TextBox).Text = "";
                }
            });
        }

        private void ShowError(string text) {
            error_lbl.Text = text;
            config_box.Controls.Add(error_lbl);
        }
        private void HandleStepText() {
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
            MailingControls.Add(step_lbl);
        }

        private void AddComputerControlsToList() {
            ComputerControls.Add(next_btn);
            ComputerControls.Add(ttl_input);
            ComputerControls.Add(ttl_lbl);
            ComputerControls.Add(ip_input);
            ComputerControls.Add(ip_lbl);
            ComputerControls.Add(name_input);
            ComputerControls.Add(name_lbl);
            ComputerControls.Add(step_lbl);
        }

        private void AddFirstStepControlsToList() {
            FirstStepControls.Add(nb_computers_input);
            FirstStepControls.Add(nb_computers_lbl);
            FirstStepControls.Add(enter_computers_btn);
        } 

        public void Update(Computer computer,string status) {
            throw new System.NotImplementedException();
        }

    }
}
