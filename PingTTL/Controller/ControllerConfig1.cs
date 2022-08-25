using PingTTL.Model;
using PingTTL.Model.Exceptions;
using System;
using System.Windows.Forms;

namespace PingTTL.Controller {
    partial class ControllerConfig {

        public void CloseConfigView(object sender,EventArgs e) {
            if(computers.Count != 0) {
                if(hasEdit) {
                    StoreEmail();
                    StoreComputersList();
                }
                try {
                    ControllerMonitoring cm = ControllerMonitoring.getInstance();
                    IsConfiguring = false;
                    cm.Computers = Computers;
                    cm.Email = Email;
                    cm.View.Show();
                    cm.StartMonitoring();
                } catch(Exception ex) {
                    Application.Exit();
                }
            } else {
                Application.Exit();
            }

        }
        private void enter_computers_btn_Click(object sender,EventArgs e) {
            Steps = Utils.GetIntFromString(View.nb_computers_input.Text) + 1;
            if(Steps > 0 && Steps <= MaxSteps) {
                View.ShowComputerFormTemplate();
                CurrentStep = 1;
                View.HandleStepText(CurrentStep,Steps);
            } else {
                View.ShowError("Erreur : Veuillez insérer un chiffre compris entre les bornes.");
                Steps = 1;
            }
        }
        private async void email_btn_Click(object sender,EventArgs e) {
            bool isNotEmptyText = true;
            bool isSuccess = false;
            View.MailingControls.ForEach(c => {
                if(c is TextBox && (c as TextBox).Text == "") {
                    isNotEmptyText = false;
                }
            });

            if(isNotEmptyText) {
                int port = Utils.GetIntFromString(View.port_input.Text);
                if(port > 0) {
                    try {
                        View.ShowLoading(true);
                        await System.Threading.Tasks.Task.Run(() =>
                        AddEmail(new Email(View.from_input.Text,View.to_input.Text,View.subject_input.Text,View.ssl_box.Checked,port,View.host_input.Text,View.password_input.Text)));
                        isSuccess = true;
                    } catch(InvalidEmailAddressException ex) {
                        View.ShowError(ex.Message);
                        View.ShowLoading(false);
                    } catch(EmailConnectionException ee) {
                        View.ShowError(ee.Message);
                        View.ShowLoading(false);
                    }
                } else {
                    View.ShowError("Erreur : Le champs '" + View.port_lbl.Text + "' doit contenir que des chiffres.");
                }
            } else {
                View.ShowError("Erreur : Tout les champs sont requis");
            }

            if(isSuccess) {
                View.ShowLoading(false);
                StoreEmail();
                View.Close();
            }
        }
        private void next_btn_Click(object sender,EventArgs e) {
            bool success = false;
            if(View.name_input.Text != "" && View.ip_input.Text != "" && View.ttl_input.Text != "") {
                int ttl = Utils.GetIntFromString(View.ttl_input.Text);
                if(ttl > 0) {
                    if(Computers.Count <= MAX_COMPUTERS_MONITORING) {
                        try {
                            AddComputer(new Computer(View.name_input.Text,View.ip_input.Text,ttl));
                            if(IsConfiguring) {
                                CurrentStep++;
                                View.HandleStepText(CurrentStep,Steps);
                                View.ClearComputerFormTemplate();
                            }
                            success = true;
                        } catch(SameIPAddressException es) {
                            View.ShowError(es.Message);
                        } catch(InvalidIPAddressException ei) {
                            View.ShowError(ei.Message);
                        } catch(InvalidNameException en) {
                            View.ShowError(en.Message);
                        }
                    } else {
                        View.ShowError("Erreur: Le programme peut contenir que 8 machines.");
                    }
                } else {
                    View.ShowError("Erreur : Le champs '" + View.ttl_lbl.Text + "' doit contenir que des chiffres.");
                }
            } else {
                View.ShowError("Erreur : Tout les champs sont requis");
            }

            if(success) {
                if(IsConfiguring && CurrentStep == Steps) {
                    View.ShowMailingFormTemplate();
                    View.HandleStepText(CurrentStep,Steps);
                    StoreComputersList();
                } else if(!IsConfiguring) {
                    View.Close();
                }
            }
        }
    }
}
