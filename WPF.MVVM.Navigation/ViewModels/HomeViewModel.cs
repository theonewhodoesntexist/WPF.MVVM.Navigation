using System.Windows.Input;

namespace WPF.MVVM.Navigation.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        #region Properties
        public string WelcomeMessage => "Welcome to my application";
        public ICommand NavigateAccountCommand { get; }
        #endregion
    }
}
