using System.Windows.Input;
using WPF.MVVM.Navigation.Commands;
using WPF.MVVM.Navigation.Stores;

namespace WPF.MVVM.Navigation.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        #region Properties
        public string Username => "J99";
        public ICommand NavigateHomeCommand { get; }
        #endregion

        #region Constructor
        public AccountViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore));
        }
        #endregion
    }
}
