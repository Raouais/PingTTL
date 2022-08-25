using PingTTL.Model;
using PingTTL.View;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace PingTTL.Controller {
    partial class ControllerConfig {

        private static readonly int MAX_COMPUTERS_MONITORING = 8;
        private int steps;
        private int currentStep;
        private static readonly string DATA_COMPUTERS_FILENAME = "ComputersData.bin";
        private static readonly string DATA_MAILING_FILENAME = "MailingData.bin";
        private List<Computer> computers;
        private Email email;
        private static ControllerConfig instance;
        private ConfigView view;
        private bool hasEdit = false;
        private bool isConfiguring;
        private bool isComputerConfigAlreadyMade;
        private bool isEmailConfigAlreadyMade;

        public int MaxSteps { get; internal set; }
        public int Steps { get => steps; set => steps = value; }
        public int CurrentStep { get => currentStep; set => currentStep = value; }
        public ConfigView View { get => view; set => view = value; }
        public List<Computer> Computers { get => computers; set => computers = value; }
        public bool IsConfiguring { get => isConfiguring; set => isConfiguring = value; }
        public bool IsEmailConfigAlreadyMade { get => isEmailConfigAlreadyMade; set => isEmailConfigAlreadyMade = value; }
        public bool IsComputerConfigAlreadyMade { get => isComputerConfigAlreadyMade; set => isComputerConfigAlreadyMade = value; }
        public Email Email { get => email; set => email = value; }

        public ControllerConfig() {
            MaxSteps = MAX_COMPUTERS_MONITORING + 1; // + 1 étape pour la partie mail
            Computers = new List<Computer>();
            createView();
            GetEmail();
            GetComputersList();
        }

        public void createView() {
            View = new ConfigView();
            View.FormClosed += new FormClosedEventHandler(CloseConfigView);
            View.next_btn.Click += new EventHandler(next_btn_Click);
            View.enter_computers_btn.Click += new EventHandler(enter_computers_btn_Click);
            View.email_btn.Click += new EventHandler(email_btn_Click);
        }

        public static ControllerConfig getInstance() {
            if(instance == null) {
                instance = new ControllerConfig();
            }
            return instance;
        }
        public void AddEmail(Email email) {
            Email = email;
        }
        public void AddComputer(Computer computer) {
            if(IsNotSameIPAdresse(computer)) {
                Computers.Add(computer);
            } else {
                throw new SameIPAddressException("Erreur : Cette adresse IP est déjà utilisée.");
            }
        }

        public void AddComputer() {
            View.AddListComponent();
            View.ShowComputerFormTemplate();
            View.Show();
            hasEdit = true;
        }
        
        public void AddEmail() {
            View.AddListComponent();
            View.ShowMailingFormTemplate();
            View.Show();
            hasEdit = true;
        }

        private bool IsNotSameIPAdresse(Computer computer) {
            return !Computers.Exists(c => c.Ip == computer.Ip);
        }

        public void StoreComputersList() {
            Utils.WriteToBinaryFile(DATA_COMPUTERS_FILENAME,Computers);
        }

        public void StoreEmail() {
            Utils.WriteToBinaryFile(DATA_MAILING_FILENAME,Email);
        }
        public void GetComputersList() {
            List<Computer> tmp = Utils.ReadFromBinaryFile<List<Computer>>(DATA_COMPUTERS_FILENAME);
            if(tmp != null && tmp.Count > 0) {
                Computers = tmp;
                IsComputerConfigAlreadyMade = true;
            }
        }
        public void GetEmail() {
            Email tmp = Utils.ReadFromBinaryFile<Email>(DATA_MAILING_FILENAME);
            if(tmp != null) {
                Email = tmp;
                IsEmailConfigAlreadyMade = true;
            }
        }
        public void Reset() {
            Computers = new List<Computer>();
            Email = null;
            StoreEmail();
            StoreComputersList();
        }
    }
}
