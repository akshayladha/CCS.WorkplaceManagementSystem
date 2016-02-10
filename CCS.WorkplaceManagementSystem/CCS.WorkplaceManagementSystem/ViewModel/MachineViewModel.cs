using System.ComponentModel;
using CCS.WorkplaceManagementSystem.Models;
using CCS.WorkplaceManagementSystem.Utilities;

namespace CCS.WorkplaceManagementSystem.ViewModel
{
    public class MachineViewModel : INotifyPropertyChanged
    {
        private Machine _machine;

        public event PropertyChangedEventHandler PropertyChanged;

        public Machine Machine
        {
            get { return _machine; }
            set { _machine = value; PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(Machine)));}
        }

        public MachineViewModel(Machine userMachine)
        {
            Machine = userMachine;
            OpenMachineDetailCommand = new RelayCommand(OpenMachineDetailsWindow);
            
        }

        private RelayCommand _openMachineDetailCommand;

        public RelayCommand OpenMachineDetailCommand
        {
            get { return _openMachineDetailCommand; }
            set { _openMachineDetailCommand = value; }
        }

        private void OpenMachineDetailsWindow(object machine)
        {
            UIServiceLinker.Notify("OpenDialog", new MachineDetailViewModel(Machine));
        }
    }
}
