using System.Windows;
using WPF.MVVM.Navigation.Services;
using WPF.MVVM.Navigation.Stores;
using WPF.MVVM.Navigation.ViewModels;

namespace WPF.MVVM.Navigation.Commands
{
    public class LoginCommand : CommandBase
    {
        #region Fields
        private readonly LoginViewModel _loginViewModel;
        private readonly NavigationService<AccountViewModel> _navigationService;
        #endregion

        #region Constructor
        public LoginCommand(LoginViewModel loginViewModel, NavigationService<AccountViewModel> navigationService)
        {
            _loginViewModel = loginViewModel;
            _navigationService = navigationService;
        }
        #endregion

        #region CommandBase
        public override void Execute(object? parameter)
        {
            MessageBox.Show($"Loggin in {_loginViewModel.Username}...");

            _navigationService.Navigate();
        }
        #endregion
    }
}
