using System.Windows.Input;
using WPF.MVVM.Navigation.Commands;
using WPF.MVVM.Navigation.Models;
using WPF.MVVM.Navigation.Services;
using WPF.MVVM.Navigation.Stores;

namespace WPF.MVVM.Navigation.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        #region Fields
        private readonly AccountStore _accountStore;
        #endregion

        #region Properties
        public string Username => _accountStore.CurrentAccount?.Username ?? "J99";
        public ICommand NavigateHomeCommand { get; }
        public NavigationBarViewModel NavigationBarViewModel { get; }
        #endregion

        #region Constructor
        public AccountViewModel(AccountStore accountStore, NavigationBarViewModel navigationBarViewModel, NavigationService<HomeViewModel> homeNavigationService)
        {
            _accountStore = accountStore;
            NavigationBarViewModel = navigationBarViewModel;

            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(homeNavigationService);
        }
        #endregion
    }
}
