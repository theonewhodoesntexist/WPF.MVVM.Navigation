using WPF.MVVM.Navigation.ViewModels;

namespace WPF.MVVM.Navigation.Services
{
    public interface INavigationService<TViewModel> where TViewModel : ViewModelBase
    {
        void Navigate();
    }
}