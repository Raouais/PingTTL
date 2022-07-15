using PingTTL.Model;
using System.Collections.Generic;


namespace PingTTL.Controller {
    public class ControllerComputer {

        private static readonly int MAX_COMPUTERS_MONITORING = 8;
        private static readonly string DATA_COMPUTERS_FILENAME = "ComputersData.bin";
        private static readonly string DATA_MAILING_FILENAME = "MailingData.bin";

        private List<Computer> computers;

        public ControllerComputer() {
            computers = new List<Computer>();
        }

        public void AddComputer(Computer computer) {
            computers.Add(computer);
        }

        public void RemoveComputer(Computer computer) {
            computers.Remove(computer);
        }

        public void StoreComputersList() {
            Utils.WriteToBinaryFile(DATA_COMPUTERS_FILENAME,computers,false);
        }

        public void GetComputersList() {
            computers = Utils.ReadFromBinaryFile<List<Computer>>(DATA_COMPUTERS_FILENAME);
        }
    }
}
