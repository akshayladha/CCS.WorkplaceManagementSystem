using System;

namespace CCS.WorkplaceManagementSystem.Models
{
    public enum MachineStatus
    {
        Active = 0,
        Away = 1,
        Shutdown = 2,
        Unknown = 3
    }

    public enum MachinePosition
    {
        TopLeft,
        TopRight,
        BottonLeft,
        BottomRight
    }

    public class Machine
    {
        public Guid MachineId { get; set; }
        public Desk Desk { get; set; }
        public string MachineNumber { get; set; }
        public int RAM { get; set; }
        public int HD { get; set; }
        public string Processor { get; set; }
        public string SystemType { get; set; }
        public string Domain { get; set; }
        public string OS { get; set; }
        public MachineStatus Status { get; set; }
        public override string ToString()
        {
            var machineText = "Machine Number : " + MachineNumber;
            return Desk != null ? machineText + "\n" + Desk : machineText;
        }
    }
}
