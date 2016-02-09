using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CCS.WorkplaceManagementSystem.Models;

namespace SQLConnectService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SQLDataConnectService" in both code and config file together.
    public class SQLDataConnectService : ISQLDataConnectService
    {
        public Machine GetMachineData(int value)
        {
            return new Machine
            {
                MachineNumber = "10000",
                Status = (MachineStatus)value,
                Desk = new Desk { DeskNumber = "PDC01" }
            };
        }

        public List<Section> GetDeskData(int status1, int status2, int status3, int status4)
        {
            return new List<Section>
            {
                new Section
                {
                    Machine1 = new Machine {MachineNumber = "10000", Status=(MachineStatus)status1 , Desk = new Desk {DeskNumber = "PDC01" } },
                    Machine2 = new Machine {MachineNumber = "10001", Status=(MachineStatus)status2 , Desk = new Desk {DeskNumber = "PDC02" } },
                    Machine3 = new Machine {MachineNumber = "10002", Status=(MachineStatus)status3 , Desk = new Desk {DeskNumber = "PDC03" } },
                    Machine4 = new Machine {MachineNumber = "10003", Status=(MachineStatus)status4 , Desk = new Desk {DeskNumber = "PDC04" } },
                },
                new Section()
                {
                    Machine1 = new Machine {MachineNumber = "20000", Status=(MachineStatus)status2 , Desk = new Desk {DeskNumber = "PDC05" } },
                    Machine2 = new Machine {MachineNumber = "20001", Status=(MachineStatus)status3 , Desk = new Desk {DeskNumber = "PDC06" } },
                    Machine3 = new Machine {MachineNumber = "20002", Status=(MachineStatus)status4 , Desk = new Desk {DeskNumber = "PDC07" } },
                    Machine4 = new Machine {MachineNumber = "20003", Status=(MachineStatus)status1 , Desk = new Desk {DeskNumber = "PDC08" } },
                }
            };
        }
    }
}
