using System;
using WPF.MVVM.Navigation.Stores;
using WPF.MVVM.Navigation.ViewModels;

namespace WPF.MVVM.Navigation.Services
{
    public class ParameterNavigationService<TParameter, TViewModel>
        where TViewModel : ViewModelBase
    {
        #region Fields
        private readonly NavigationStore _navigationStore;
        private Func<TParameter, TViewModel> _createViewModel;
        #endregion

        #region Constructor
        public ParameterNavigationService(NavigationStore navigationStore, Func<TParameter, TViewModel> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }
        #endregion

        #region Helper methods
        public void Navigate(TParameter parameter)
        {
            _navigationStore.CurrentViewModel = _createViewModel(parameter);
        }
        #endregion
    }
}
