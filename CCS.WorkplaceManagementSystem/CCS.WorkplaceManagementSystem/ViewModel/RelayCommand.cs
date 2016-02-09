using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CCS.WorkplaceManagementSystem
{
    public class RelayCommand : ICommand
    {
        private Action _execute;

        public RelayCommand(Action action)
        {
            _execute = action;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute();
        }
    }
}
