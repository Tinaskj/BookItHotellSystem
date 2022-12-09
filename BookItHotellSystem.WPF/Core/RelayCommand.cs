using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BookItHotellSystem.WPF.Core
{
    internal class RelayCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExeute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public RelayCommand(Action<object> execute, Func<object, bool> canExeute = null)
        {
            _execute = execute;
            _canExeute = canExeute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExeute == null || _canExeute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
