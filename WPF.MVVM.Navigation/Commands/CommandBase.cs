using System.Windows.Input;
using System;

namespace WPF.MVVM.Navigation.Commands
{
    public abstract class CommandBase : ICommand
    {
        #region ICommand
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public abstract void Execute(object? parameter);
        #endregion

        #region Helper methods
        protected void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
        #endregion
    }
}
