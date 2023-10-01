using System.Windows.Input;
using WPF.MVVM.Navigation.Commands;
using WPF.MVVM.Navigation.Stores;

namespace WPF.MVVM.Navigation.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        #region Properties
        public string WelcomeMessage => "Welcome to my application";
        public ICommand NavigateAccountCommand { get; }
        #endregion

        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateAccountCommand = new NavigateCommand<AccountViewModel>(navigationStore, () => new AccountViewModel(navigationStore));
        }
    }
}
