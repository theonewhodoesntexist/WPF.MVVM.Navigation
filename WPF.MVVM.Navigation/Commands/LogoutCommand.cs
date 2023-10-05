using WPF.MVVM.Navigation.Stores;

namespace WPF.MVVM.Navigation.Commands
{
    public class LogoutCommand : CommandBase
    {
        #region Fields
        private readonly AccountStore _accountStore;
        #endregion

        #region Constructor
        public LogoutCommand(AccountStore accountStore)
        {
            _accountStore = accountStore;
        }
        #endregion

        #region CommandBase
        public override void Execute(object? parameter)
        {
            _accountStore.Logout();
        }
        #endregion
    }
}
