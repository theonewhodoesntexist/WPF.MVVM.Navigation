using WPF.MVVM.Navigation.Models;

namespace WPF.MVVM.Navigation.Stores
{
    public class AccountStore
    {
		#region Properties
		private AccountModel _currentAccount;
		public AccountModel CurrentAccount
		{
			get
			{
				return _currentAccount;
			}
			set
			{
                _currentAccount = value;
			}
		}
		#endregion
	}
}
