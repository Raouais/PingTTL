using PingTTL.Model;
using System.Collections.Generic;


namespace PingTTL.Controller {
    public class ControllerComputer {

        private static readonly int MAX_COMPUTERS_MONITORING = 8;
        private static readonly string FILENAME = "ComputersData.bin";

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
            Utils.WriteToBinaryFile(FILENAME,computers,false);
        }

        public void GetComputersList() {
            computers = Utils.ReadFromBinaryFile<List<Computer>>(FILENAME);
        }
    }
}
