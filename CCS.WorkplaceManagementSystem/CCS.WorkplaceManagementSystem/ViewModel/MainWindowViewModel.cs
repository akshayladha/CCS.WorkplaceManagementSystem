using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Timers;
using CCS.WorkplaceManagementSystem.Models;
using CCS.WorkplaceManagementSystem.Utilities;
using Timer = System.Timers.Timer;

namespace CCS.WorkplaceManagementSystem.ViewModel
{

    
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private List<Section> _deskList;

        public List<Section> DeskList
        {
            get { return _deskList; }
            set { _deskList = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DeskList))); }
        }

        private MachineViewModel _machineContent;

        public MachineViewModel MachineContent
        {
            get { return _machineContent; }
            set { _machineContent = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MachineContent))); }
        }

        private Machine _machine;

        public Machine UserMachine
        {
            get { return _machine; }
            set { _machine = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UserMachine))); }
        }

        private RelayCommand _getDataFromServiceCommand;

        public RelayCommand GetDataFromServiceCommand
        {
            get { return _getDataFromServiceCommand; }
            set { _getDataFromServiceCommand = value; }
        }

        private RelayCommand _openMachineDetailCommand;

        public RelayCommand OpenMachineDetailCommand
        {
            get { return _openMachineDetailCommand; }
            set { _openMachineDetailCommand = value; }
        }

        private int _statusCode1 = 0;
        private int _statusCode2 = 1;
        private int _statusCode3 = 2;
        private int _statusCode4 = 3;
        private bool _useTimer;

        

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel()
        {
            GetDataFromServiceCommand = new RelayCommand(GetServiceData);
            OpenMachineDetailCommand = new RelayCommand(OpenMachineDetailsWindow);//Initialize UIService
            var service = new UIService();
            service.Initialize();
            var t = new Timer(3000);
            t.Elapsed += T_Elapsed;
            t.Enabled = true;
        }

        private void OpenMachineDetailsWindow(object machine)
        {
            Mediator.NotifyColleagues("OpenDialog",new MachineDetailViewModel(machine as Machine));
        }

        private void GetServiceData(object uselessParam)
        {                   
            var client = new GetDataService.GetDataServiceClient();
            DeskList = client.GetDeskData(_statusCode1, _statusCode2, _statusCode3, _statusCode4).ToList();
            UserMachine = client.GetMachineData(_statusCode1);
            MachineContent = new MachineViewModel(UserMachine);
            _useTimer = true;
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
            if (_useTimer)
                GetServiceData(null);
        }

        //public void CreateData(int status1, int status2, int status3, int status4)
        //{
        //    DeskList = new List<Section>
        //    {
        //        new Section
        //        {
        //            Machine1 = new Machine {MachineNumber = "10000", Status=(MachineStatus)status1 , Desk = new Desk {DeskNumber = "PDC01" } },
        //            Machine2 = new Machine {MachineNumber = "10001", Status=(MachineStatus)status2 , Desk = new Desk {DeskNumber = "PDC02" } },
        //            Machine3 = new Machine {MachineNumber = "10002", Status=(MachineStatus)status3 , Desk = new Desk {DeskNumber = "PDC03" } },
        //            Machine4 = new Machine {MachineNumber = "10003", Status=(MachineStatus)status4 , Desk = new Desk {DeskNumber = "PDC04" } },
        //        },
        //        new Section()
        //        {
        //            Machine1 = new Machine {MachineNumber = "20000", Status=(MachineStatus)status2 , Desk = new Desk {DeskNumber = "PDC05" } },
        //            Machine2 = new Machine {MachineNumber = "20001", Status=(MachineStatus)status3 , Desk = new Desk {DeskNumber = "PDC06" } },
        //            Machine3 = new Machine {MachineNumber = "20002", Status=(MachineStatus)status4 , Desk = new Desk {DeskNumber = "PDC07" } },
        //            Machine4 = new Machine {MachineNumber = "20003", Status=(MachineStatus)status1 , Desk = new Desk {DeskNumber = "PDC08" } },
        //        },
        //    };
        //}

        //public void CreateMachine(int status1)
        //{
        //    UserMachine = new Machine
        //    {
        //        MachineNumber = "10000",
        //        Status = (MachineStatus)status1,
        //        Desk = new Desk { DeskNumber = "PDC01" }
        //    };
        //}

    }

    
}
