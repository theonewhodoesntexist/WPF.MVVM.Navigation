namespace WPF.MVVM.Navigation.Models
{
    public class AccountModel
    {
        #region Properties
        public string Username { get; }
        public string Password { get; }
        #endregion

        #region Constructor
        public AccountModel(string username, string password)
        {
            Username = username;
            Password = password;
        }
        #endregion
    }
}
