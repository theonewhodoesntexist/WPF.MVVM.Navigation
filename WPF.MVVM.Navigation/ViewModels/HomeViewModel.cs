using System.Windows.Input;
using WPF.MVVM.Navigation.Commands;
using WPF.MVVM.Navigation.Services;
using WPF.MVVM.Navigation.Stores;

namespace WPF.MVVM.Navigation.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        #region Properties
        public string WelcomeMessage => "Welcome to my application";
        public ICommand NavigateLoginCommand { get; }
        public NavigationBarViewModel NavigationBarViewModel { get; }
        #endregion

        public HomeViewModel(NavigationBarViewModel navigationBarViewModel, NavigationService<LoginViewModel> loginNavigationService)
        {
            NavigationBarViewModel = navigationBarViewModel;

            NavigateLoginCommand = new NavigateCommand<LoginViewModel>(loginNavigationService);
        }
    }
}
