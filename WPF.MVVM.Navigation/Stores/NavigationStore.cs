using System;
using WPF.MVVM.Navigation.ViewModels;

namespace WPF.MVVM.Navigation.Stores
{
    public class NavigationStore
    {
		#region Properties
		private ViewModelBase _currentViewModel;
		public ViewModelBase CurrentViewModel
		{
			get
			{
				return _currentViewModel;
			}
			set
			{
				_currentViewModel?.Dispose();
                _currentViewModel = value;
				CurrentViewModelChanged?.Invoke();
            }
		}
		#endregion

		#region Events
		public event Action CurrentViewModelChanged;
        #endregion
    }
}
