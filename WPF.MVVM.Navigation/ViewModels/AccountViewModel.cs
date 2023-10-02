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
        private readonly NavigationStore _navigationStore;
        private readonly AccountModel _accountModel;
        #endregion

        #region Properties
        public string Username => _accountModel?.Username ?? "J99";
        public ICommand NavigateHomeCommand { get; }
        #endregion

        #region Constructor
        public AccountViewModel(NavigationStore navigationStore, AccountModel accountModel)
        {
            _navigationStore = navigationStore;
            _accountModel = accountModel;

            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(new NavigationService<HomeViewModel>(_navigationStore, () => new HomeViewModel(_navigationStore)));
        }
        #endregion
    }
}
