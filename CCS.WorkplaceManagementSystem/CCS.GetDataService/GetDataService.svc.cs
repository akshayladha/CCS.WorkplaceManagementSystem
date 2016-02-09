using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CCS.WorkplaceManagementSystem.Models;

namespace CCS.GetDataService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GetDataService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GetDataService.svc or GetDataService.svc.cs at the Solution Explorer and start debugging.
    public class GetDataService : IGetDataService
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
                },
            };
        }
    }
}
