using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SPMaintenance.Utils
{
    class CustomCommand : ICommand
    {
        private Action<object> execute;
        private Predicate<object> canExecute;
        public CustomCommand(Action<object> execute, Predicate<object> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            bool result = true;
            if (this.canExecute != null)
            {
                result = this.canExecute(parameter);
            }
            return result;
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
