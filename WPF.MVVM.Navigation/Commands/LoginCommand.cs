using System.Windows;
using WPF.MVVM.Navigation.Models;
using WPF.MVVM.Navigation.Services;
using WPF.MVVM.Navigation.Stores;
using WPF.MVVM.Navigation.ViewModels;

namespace WPF.MVVM.Navigation.Commands
{
    public class LoginCommand : CommandBase
    {
        #region Fields
        private readonly LoginViewModel _loginViewModel;
        private readonly INavigationService _navigationService;
        private readonly AccountStore _accountStore;
        #endregion

        #region Constructor
        public LoginCommand(LoginViewModel loginViewModel, INavigationService navigationService, AccountStore accountStore)
        {
            _loginViewModel = loginViewModel;
            _navigationService = navigationService;
            _accountStore = accountStore;
        }
        #endregion

        #region CommandBase
        public override void Execute(object? parameter)
        {
            AccountModel accountModel = new AccountModel(_loginViewModel.Username, _loginViewModel.Password);

            _accountStore.CurrentAccount = accountModel;

            _navigationService.Navigate();
        }
        #endregion
    }
}
