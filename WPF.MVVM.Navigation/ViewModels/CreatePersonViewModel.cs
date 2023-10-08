using System.Windows.Input;
using WPF.MVVM.Navigation.Commands;
using WPF.MVVM.Navigation.Services;
using WPF.MVVM.Navigation.Stores;

namespace WPF.MVVM.Navigation.ViewModels
{
    public class CreatePersonViewModel : ViewModelBase
    {
        #region Properties
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }
        #endregion

        #region Constructor
        public CreatePersonViewModel(INavigationService cancelNavigationService, PeopleStore peopleStore)
        {
            SubmitCommand = new CreatePersonCommand(this, cancelNavigationService, peopleStore);
            CancelCommand = new NavigateCommand(cancelNavigationService);
        }
        #endregion
    }
}
