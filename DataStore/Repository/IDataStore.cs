using System.Collections.Generic;
using UsersProfileApp.DataStore.Models;

namespace UsersProfileApp.DataStore.Repository
{
    public interface IDataStore
    {
        IEnumerable<Users> GetUsers();

        void SaveUser(Users user);

    }
}
