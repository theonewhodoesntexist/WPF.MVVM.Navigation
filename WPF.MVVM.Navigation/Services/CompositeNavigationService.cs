using System.Collections.Generic;

namespace WPF.MVVM.Navigation.Services
{
    public class CompositeNavigationService : INavigationService
    {
        #region Fields
        private readonly IEnumerable<INavigationService> _navigationServices;
        #endregion

        #region Constructor
        public CompositeNavigationService(params INavigationService[] navigationServices)
        {
            _navigationServices = navigationServices;
        }
        #endregion

        #region INavigationService
        public void Navigate()
        {
            foreach (INavigationService navigationService in _navigationServices)
            {
                navigationService.Navigate();
            }
        }
        #endregion
    }
}
