using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCS.WorkplaceManagementSystem.Models;

namespace CCS.WorkplaceManagementSystem
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
