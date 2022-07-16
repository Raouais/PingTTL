using PingTTL.View;
using PingTTL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            ControllerTask controlerT = new ControllerTask();
            ControllerConfig controllerC = new ControllerConfig();
            ConfigView configView = new ConfigView(controllerC);
            configView.ShowFirstStepTemplate();
            Application.Run(configView);
        }
    }
}
