using WPF.MVVM.Navigation.Stores;

namespace WPF.MVVM.Navigation.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        #region Fields
        private readonly NavigationStore _navigationStore;
        #endregion

        #region Properties
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
        #endregion

        #region Constructor
        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;

            _navigationStore.CurrentViewModelChanged += NavigationStore_CurrentViewModelChanged;
        }

        #region CurrentViewModelChanged Subscribed
        private void NavigationStore_CurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
        #endregion

        #region Unsubscribed
        protected override void Dispose()
        {
            _navigationStore.CurrentViewModelChanged -= NavigationStore_CurrentViewModelChanged;

            base.Dispose();
        }
        #endregion
        #endregion
    }
}
