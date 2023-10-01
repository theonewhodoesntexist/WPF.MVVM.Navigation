using System.Windows.Input;

namespace WPF.MVVM.Navigation.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        #region Properties
        public string Username => "J99";
        public ICommand NavigateHomeCommand { get; }
        #endregion
    }
}
