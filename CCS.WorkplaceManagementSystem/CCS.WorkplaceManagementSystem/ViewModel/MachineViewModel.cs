using System.ComponentModel;
using CCS.WorkplaceManagementSystem.Models;

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
        }
    }
}
