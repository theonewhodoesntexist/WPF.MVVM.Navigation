using WPF.MVVM.Navigation.Stores;

namespace WPF.MVVM.Navigation.ViewModels
{
    public class PeopleListingItemViewModel : ViewModelBase
    {
        #region Properties
        public string Name { get; }
        #endregion

        #region Constructor
        public PeopleListingItemViewModel(string name)
        {
            Name = name;
        }
        #endregion
    }
}
