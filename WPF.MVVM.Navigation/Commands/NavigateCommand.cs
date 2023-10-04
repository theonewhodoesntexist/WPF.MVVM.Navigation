using System;
using WPF.MVVM.Navigation.Services;
using WPF.MVVM.Navigation.Stores;
using WPF.MVVM.Navigation.ViewModels;

namespace WPF.MVVM.Navigation.Commands
{
    public class NavigateCommand<TViewModel> : CommandBase
        where TViewModel : ViewModelBase
    {
        #region Fields
        private readonly INavigationService<TViewModel> _navigationService;
        #endregion

        #region Constructor
        public NavigateCommand(INavigationService<TViewModel> navigationService)
        {
            _navigationService = navigationService;
        }
        #endregion

        #region CommandBase
        public override void Execute(object? parameter)
        {
            _navigationService.Navigate();
        }
        #endregion
    }
}
