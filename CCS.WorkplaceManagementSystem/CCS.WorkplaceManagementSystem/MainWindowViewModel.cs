using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using Timer = System.Timers.Timer;

namespace CCS.WorkplaceManagementSystem
{

    public enum MachineStatus
    {
        Active = 0,
        Away = 1,
        Shutdown = 2,
        Unknown = 3
    }
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private List<Section> _deskList;

        public List<Section> DeskList
        {
            get { return _deskList; }
            set { _deskList = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DeskList)));}
        }

        private MachineViewModel _machineContent;

        public MachineViewModel MachineContent
        {
            get { return _machineContent; }
            set { _machineContent = value;PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(MachineContent))); }
        }
        

        private int _statusCode1 = 0;
        private int _statusCode2 = 1;
        private int _statusCode3 = 2;
        private int _statusCode4 = 3;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel()
        {
            MachineContent = new MachineViewModel();
            CreateData(_statusCode1, _statusCode2, _statusCode3, _statusCode4);
            var t = new Timer(3000);
            t.Elapsed += T_Elapsed;
            t.Enabled = true;
        }

        private void T_Elapsed(object sender, ElapsedEventArgs e)
        {
            _statusCode1++;
            _statusCode2++;
            _statusCode3++;
            _statusCode4++;
            if (_statusCode1 > 3) _statusCode1 = 0;
            if (_statusCode2 > 3) _statusCode2 = 0;
            if (_statusCode3 > 3) _statusCode3 = 0;
            if (_statusCode4 > 3) _statusCode4 = 0;
            CreateData(_statusCode1, _statusCode2, _statusCode3, _statusCode4);
        }

        private void CreateData(int status1, int status2, int status3, int status4)
        {
            DeskList = new List<Section>
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
