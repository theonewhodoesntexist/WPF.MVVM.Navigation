namespace WPF.MVVM.Navigation.ViewModels
{
    public class LayoutViewModel : ViewModelBase
    {
        #region Properties
        public NavigationBarViewModel NavigationBarViewModel { get; }
        public ViewModelBase ContentViewModel { get; }
        #endregion

        #region Constructor
        public LayoutViewModel(NavigationBarViewModel navigationBarViewModel, ViewModelBase contentViewModel)
        {
            NavigationBarViewModel = navigationBarViewModel;
            ContentViewModel = contentViewModel;
        }
        #endregion

        #region Dispose
        public override void Dispose()
        {
            NavigationBarViewModel.Dispose();
            ContentViewModel.Dispose();

            base.Dispose();
        }
        #endregion
    }
}
