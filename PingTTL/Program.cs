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

            ControllerMonitoring controllerM = ControllerMonitoring.getInstance();
            ControllerConfig controllerC = ControllerConfig.getInstance();

            if(!controllerC.IsComputerConfigAlreadyMade) {
                controllerC.IsConfiguring = true;
                controllerC.View.IsStepsNeeded = true;
                controllerC.View.AddListComponent();
                controllerC.View.ShowFirstStepTemplate();
                controllerC.View.Show();
            } else if(!controllerC.IsEmailConfigAlreadyMade) {
                controllerC.View.AddListComponent();
                controllerC.View.ShowMailingFormTemplate();
                controllerC.View.Show();
            } else {
                controllerM.Computers = controllerC.Computers;
                controllerM.Email = controllerC.Email;
                controllerM.StartMonitoring();
                controllerM.View.Show();
            }
            Application.Run();
        }
    }
}
