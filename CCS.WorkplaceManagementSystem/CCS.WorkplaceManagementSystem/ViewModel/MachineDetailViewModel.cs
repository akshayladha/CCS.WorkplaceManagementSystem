using System.ComponentModel;
using System.Runtime.CompilerServices;
using CCS.WorkplaceManagementSystem.Annotations;
using CCS.WorkplaceManagementSystem.Models;

namespace CCS.WorkplaceManagementSystem.ViewModel
{
    public class MachineDetailViewModel : INotifyPropertyChanged
    {
        private Machine _machineDetailsList;

        public Machine MachineDetails
        {
            get { return _machineDetailsList; }
            set
            {
                _machineDetailsList = value;
                RaisePropertyChange(nameof(MachineDetails));
            }
        }

        public MachineDetailViewModel(Machine machine)
        {
            MachineDetails = machine;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void RaisePropertyChange([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
