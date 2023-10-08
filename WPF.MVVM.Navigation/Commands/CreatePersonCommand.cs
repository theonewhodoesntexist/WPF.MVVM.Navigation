using WPF.MVVM.Navigation.Services;
using WPF.MVVM.Navigation.Stores;
using WPF.MVVM.Navigation.ViewModels;

namespace WPF.MVVM.Navigation.Commands
{
    public class CreatePersonCommand : CommandBase
    {
        #region Fields
        private readonly CreatePersonViewModel _createPersonViewModel;
        private INavigationService _navigationService;
        private readonly PeopleStore _peopleStore;
        #endregion

        #region Constructor
        public CreatePersonCommand(CreatePersonViewModel createPersonViewModel, INavigationService navigationService, PeopleStore peopleStore)
        {
            _createPersonViewModel = createPersonViewModel;
            _navigationService = navigationService;
            _peopleStore = peopleStore;
        }
        #endregion

        #region CommandBase
        public override void Execute(object? parameter)
        {
            string name = _createPersonViewModel.Name;
            _peopleStore.Create(name);

            _navigationService.Navigate();
        }
        #endregion
    }
}
