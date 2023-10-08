using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Xml.Linq;
using WPF.MVVM.Navigation.Commands;
using WPF.MVVM.Navigation.Services;
using WPF.MVVM.Navigation.Stores;

namespace WPF.MVVM.Navigation.ViewModels
{
    public class PeopleListingViewModel : ViewModelBase
    {
        #region Fields
        private readonly ObservableCollection<PeopleListingItemViewModel> _peopleListingItemViewModel;
        private readonly PeopleStore _peopleStore;
        #endregion

        #region Properties
        public IEnumerable<PeopleListingItemViewModel> PeopleListingItemViewModel => _peopleListingItemViewModel;
        public ICommand CreatePersonCommand { get; }
        #endregion

        #region Constructor
        public PeopleListingViewModel(INavigationService createPersonNavigationService, PeopleStore peopleStore)
        {
            _peopleListingItemViewModel = new ObservableCollection<PeopleListingItemViewModel>();
            _peopleStore = peopleStore;

            CreatePersonCommand = new NavigateCommand(createPersonNavigationService);

            _peopleListingItemViewModel.Add(new PeopleListingItemViewModel("a"));
            _peopleListingItemViewModel.Add(new PeopleListingItemViewModel("b"));
            _peopleListingItemViewModel.Add(new PeopleListingItemViewModel("c"));

            _peopleStore.PersonCreated += PeopleStore_PersonCreated;
        }

        #region PersonCreated Subscribed
        private void PeopleStore_PersonCreated(string name)
        {
            _peopleListingItemViewModel.Add(new PeopleListingItemViewModel(name));
        }
        #endregion
        #endregion
    }
}
