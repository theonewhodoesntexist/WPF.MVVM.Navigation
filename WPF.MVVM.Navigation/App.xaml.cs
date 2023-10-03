using System;
using System.Windows;
using WPF.MVVM.Navigation.Services;
using WPF.MVVM.Navigation.Stores;
using WPF.MVVM.Navigation.ViewModels;

namespace WPF.MVVM.Navigation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Fields
        private readonly NavigationStore _navigationStore;
        private readonly AccountStore _accountStore;
        private readonly NavigationBarViewModel _navigationBarViewModel;
        #endregion

        #region Constructor
        public App()
        {
            _navigationStore = new NavigationStore();
            _accountStore = new AccountStore();
            _navigationBarViewModel = new NavigationBarViewModel(CreateHomeNavigationService(), CreateAccountNavigationService(), CreateLoginNavigationService(), _accountStore);
        }
        #endregion

        #region Startup configurations
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            NavigationService<HomeViewModel> homeNavigationService = CreateHomeNavigationService();
            homeNavigationService.Navigate();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();
        }
        #endregion

        #region Helper methods
        private NavigationService<HomeViewModel> CreateHomeNavigationService()
        {
            return new NavigationService<HomeViewModel>(_navigationStore, () => new HomeViewModel(_navigationBarViewModel, CreateLoginNavigationService()));
        }

        private NavigationService<AccountViewModel> CreateAccountNavigationService()
        {
            return new NavigationService<AccountViewModel>(_navigationStore, () => new AccountViewModel(_accountStore, _navigationBarViewModel, CreateHomeNavigationService()));
        }

        private NavigationService<LoginViewModel> CreateLoginNavigationService()
        {
            return new NavigationService<LoginViewModel>(_navigationStore, () => new LoginViewModel(_accountStore, CreateAccountNavigationService()));
        }
        #endregion
    }
}
