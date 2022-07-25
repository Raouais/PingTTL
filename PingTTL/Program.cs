using PingTTL.View;
using PingTTL.Controller;
using System;
using System.Windows.Forms;

namespace PingTTL {
    internal static class Program {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfigView configView = new ConfigView();
            MonitoringView MonitorView = new MonitoringView();

            ControllerMonitoring controllerM = ControllerMonitoring.getInstance(MonitorView);
            ControllerConfig controllerC = ControllerConfig.getInstance(configView);

            if(!controllerC.IsConfigAlreadyMade()) {
                controllerC.View.IsStepsNeeded = true;
                controllerC.View.AddListComponent();
                controllerC.View.ShowFirstStepTemplate();
                controllerC.View.Show();
            } else if(!controllerC.IsEmailConfigAlreadyMade()) {
                controllerC.View.AddListComponent();
                controllerC.View.ShowMailingFormTemplate();
                controllerC.View.Show();
            } else {
                //show monitoring
                controllerM.StartMonitoring();
                controllerM.View.ShowMonitoring();
            }
            Application.Run(controllerM.View);
        }
    }
}
