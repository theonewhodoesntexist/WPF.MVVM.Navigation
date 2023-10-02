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
        private readonly ParameterNavigationService<AccountModel, AccountViewModel> _parameterNavigationService;
        #endregion

        #region Constructor
        public LoginCommand(LoginViewModel loginViewModel, ParameterNavigationService<AccountModel, AccountViewModel> parameterNavigationService)
        {
            _loginViewModel = loginViewModel;
            _parameterNavigationService = parameterNavigationService;
        }
        #endregion

        #region CommandBase
        public override void Execute(object? parameter)
        {
            AccountModel accountModel = new AccountModel(_loginViewModel.Username, _loginViewModel.Password);

            _parameterNavigationService.Navigate(accountModel);
        }
        #endregion
    }
}
