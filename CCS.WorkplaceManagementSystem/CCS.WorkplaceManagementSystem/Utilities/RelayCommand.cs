using System;
using System.Windows.Input;

namespace CCS.WorkplaceManagementSystem.Utilities
{
    public class RelayCommand : ICommand
    {
        private Action<object> _execute;

        public RelayCommand(Action<object> action)
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
            _execute(parameter);
        }
    }
}
