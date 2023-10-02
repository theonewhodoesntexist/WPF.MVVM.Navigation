using System.Windows.Input;
using WPF.MVVM.Navigation.Commands;
using WPF.MVVM.Navigation.Models;
using WPF.MVVM.Navigation.Services;
using WPF.MVVM.Navigation.Stores;

namespace WPF.MVVM.Navigation.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
		#region Properties
		private string _username;
		public string Username
		{
			get
			{
				return _username;
			}
			set
			{
                _username = value;
			}
		}

		private string _password;
		public string Password
		{
			get
			{
				return _password;
			}
			set
			{
                _password = value;
			}
		}

		public ICommand LoginCommand { get; }
        #endregion

        #region Constructor
        public LoginViewModel(NavigationStore navigationStore)
        {
			ParameterNavigationService<AccountModel, AccountViewModel> parameterNavigationService = new ParameterNavigationService<AccountModel, AccountViewModel>(navigationStore, (parameter) => new AccountViewModel(navigationStore, parameter));

			LoginCommand = new LoginCommand(this, parameterNavigationService);
        }
        #endregion
    }
}
