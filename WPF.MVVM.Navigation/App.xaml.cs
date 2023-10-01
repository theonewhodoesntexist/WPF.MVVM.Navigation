using System.Windows;
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
        #endregion

        #region Constructor
        public App()
        {
            _navigationStore = new NavigationStore();
        }
        #endregion

        #region Startup configurations
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new HomeViewModel(_navigationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();
        }
        #endregion
    }
}
