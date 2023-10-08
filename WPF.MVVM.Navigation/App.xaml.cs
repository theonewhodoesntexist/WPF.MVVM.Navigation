using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using WPF.MVVM.Navigation.Services;
using WPF.MVVM.Navigation.Stores;
using WPF.MVVM.Navigation.ViewModels;

namespace WPF.MVVM.Navigation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Fields
        private readonly IServiceProvider _serviceProvider;
        #endregion

        #region Constructor
        public App()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<NavigationStore>();
            services.AddSingleton<AccountStore>();
            services.AddSingleton<ModalNavigationStore>();
            services.AddSingleton<PeopleStore>();

            services.AddSingleton<INavigationService>(s => CreateHomeNavigationService(s));
            services.AddSingleton<CloseModalNavigationService>();

            services.AddTransient<HomeViewModel>(s => new HomeViewModel(CreateLoginNavigationService(s)));
            services.AddTransient<AccountViewModel>(s => new AccountViewModel(s.GetRequiredService<AccountStore>(), CreateHomeNavigationService(s)));
            services.AddTransient<LoginViewModel>(CreateLoginViewModel);
            services.AddTransient<PeopleListingViewModel>(s => new PeopleListingViewModel(CreateCreatePersonNavigationService(s), s.GetRequiredService<PeopleStore>()));
            services.AddTransient<CreatePersonViewModel>(s => new CreatePersonViewModel(s.GetRequiredService<CloseModalNavigationService>(), s.GetRequiredService<PeopleStore>()));
            services.AddTransient<NavigationBarViewModel>(CreateNavigationBarViewModel);

            services.AddSingleton<MainViewModel>();

            services.AddSingleton<MainWindow>(s => new MainWindow()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            _serviceProvider = services.BuildServiceProvider();
        }
        #endregion

        #region Startup configurations
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            INavigationService initialNavigationService = _serviceProvider.GetRequiredService<INavigationService>();
            initialNavigationService.Navigate();

            MainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            MainWindow.Show();
        }
        #endregion

        #region Helper methods
        private INavigationService CreateHomeNavigationService(IServiceProvider serviceProvider)
        {
            NavigationStore navigationStore = serviceProvider.GetRequiredService<NavigationStore>();
            HomeViewModel homeViewModel = serviceProvider.GetRequiredService<HomeViewModel>();

            return new LayoutNavigationService<HomeViewModel>(
                navigationStore, 
                () => homeViewModel, 
                () => serviceProvider.GetRequiredService<NavigationBarViewModel>());
        }

        private INavigationService CreateAccountNavigationService(IServiceProvider serviceProvider)
        {
            NavigationStore navigationStore = serviceProvider.GetRequiredService<NavigationStore>();
            AccountStore accountStore = serviceProvider.GetRequiredService<AccountStore>();

            return new LayoutNavigationService<AccountViewModel>(
                navigationStore, 
                () => serviceProvider.GetRequiredService<AccountViewModel>(), 
                () => serviceProvider.GetRequiredService<NavigationBarViewModel>());
        }

        private INavigationService CreateLoginNavigationService(IServiceProvider serviceProvider)
        {
            return new ModalNavigationService<LoginViewModel>(
                serviceProvider.GetRequiredService<ModalNavigationStore>(), 
                () => serviceProvider.GetRequiredService<LoginViewModel>());
        }

        private NavigationBarViewModel CreateNavigationBarViewModel(IServiceProvider serviceProvider)
        {
            AccountStore accountStore = serviceProvider.GetRequiredService<AccountStore>();

            return new NavigationBarViewModel(
                CreateHomeNavigationService(serviceProvider), 
                CreateAccountNavigationService(serviceProvider), 
                CreateLoginNavigationService(serviceProvider), 
                accountStore,
                CreatePeopleListingNavigationService(serviceProvider));
        }

        private LoginViewModel CreateLoginViewModel(IServiceProvider serviceProvider)
        {
            CompositeNavigationService compositeNavigationService = new CompositeNavigationService(
                serviceProvider.GetRequiredService<CloseModalNavigationService>(), 
                CreateAccountNavigationService(serviceProvider));

            return new LoginViewModel(
                serviceProvider.GetRequiredService<AccountStore>(), 
                compositeNavigationService);
        }

        private INavigationService CreatePeopleListingNavigationService(IServiceProvider serviceProvider)
        {
            NavigationStore navigationStore = serviceProvider.GetRequiredService<NavigationStore>();
            AccountStore accountStore = serviceProvider.GetRequiredService<AccountStore>();

            return new LayoutNavigationService<PeopleListingViewModel>(serviceProvider.GetRequiredService<NavigationStore>(),
                () => serviceProvider.GetRequiredService<PeopleListingViewModel>(),
                () => serviceProvider.GetRequiredService<NavigationBarViewModel>());
        }

        private INavigationService CreateCreatePersonNavigationService(IServiceProvider serviceProvider)
        {
            return new ModalNavigationService<CreatePersonViewModel>(
                serviceProvider.GetRequiredService<ModalNavigationStore>(),
                () => serviceProvider.GetRequiredService<CreatePersonViewModel>());
        }
        #endregion
    }
}
