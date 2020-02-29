using System;
using System.Windows.Input;

namespace Recademy.Desktop.BaseMvvmElements
{
    public class ActionCommand : ICommand
    {
        private readonly Action _action;
        private readonly Func<bool> _isCanExec;

        public ActionCommand(Action action, Func<bool> isCanExec = null)
        {
            _action = action;
            _isCanExec = isCanExec;
        }

        public bool CanExecute(object parameter)
        {
            return _isCanExec == null || _isCanExec();
        }

        public void Execute(object parameter)
        {
            if (parameter != null)
                throw new ArgumentException();
            _action();
        }

        public event EventHandler CanExecuteChanged;
    }
}