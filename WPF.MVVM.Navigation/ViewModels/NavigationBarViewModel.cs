﻿using System.Windows.Input;
using WPF.MVVM.Navigation.Commands;
using WPF.MVVM.Navigation.Services;
using WPF.MVVM.Navigation.Stores;

namespace WPF.MVVM.Navigation.ViewModels
{
    public class NavigationBarViewModel : ViewModelBase
    {
        #region Fields
        private readonly AccountStore _accountStore;
        #endregion

        #region Properties
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateAccountCommand { get; }
        public ICommand NavigateLoginCommand { get; }
        public bool IsLoggedIn => _accountStore.IsLoggedIn;
        public ICommand LogoutCommand { get; }
        #endregion

        #region Constructor
        public NavigationBarViewModel(INavigationService<HomeViewModel> homeNavigationService, INavigationService<AccountViewModel> accountNavigationService, INavigationService<LoginViewModel> loginNavigationService, AccountStore accountStore)
        {
            _accountStore = accountStore;

            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(homeNavigationService);
            NavigateAccountCommand = new NavigateCommand<AccountViewModel>(accountNavigationService);
            NavigateLoginCommand = new NavigateCommand<LoginViewModel>(loginNavigationService);
            LogoutCommand = new LogoutCommand(_accountStore);

            _accountStore.CurrentAccountChanged += AccountStore_CurrentAccountChanged;
        }

        #region CurrentAccountChanged Subscribed
        private void AccountStore_CurrentAccountChanged()
        {
            OnPropertyChanged(nameof(IsLoggedIn));
        }
        #endregion
        #endregion

        #region Dispose
        public override void Dispose()
        {
            _accountStore.CurrentAccountChanged -= AccountStore_CurrentAccountChanged;

            base.Dispose();
        }
        #endregion
    }
}
