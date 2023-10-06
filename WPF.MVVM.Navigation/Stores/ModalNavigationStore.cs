using System;
using WPF.MVVM.Navigation.ViewModels;

namespace WPF.MVVM.Navigation.Stores
{
    public class ModalNavigationStore
    {
        #region Properties
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel?.Dispose();
                _currentViewModel = value;
                CurrentViewModelChanged?.Invoke();
            }
        }

        public bool IsOpen => CurrentViewModel != null;
        #endregion

        #region Helper methods
        public void Close()
        {
            CurrentViewModel = null;
        }
        #endregion

        #region Events
        public event Action CurrentViewModelChanged;
        #endregion
    }
}
