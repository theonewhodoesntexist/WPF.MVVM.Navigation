using System;

namespace WPF.MVVM.Navigation.Stores
{
    public class PeopleStore
    {
        #region Events
        public event Action<string> PersonCreated;
        #endregion

        #region Helper methods
        public void Create(string name)
        {
            PersonCreated?.Invoke(name);
        }
        #endregion
    }
}
