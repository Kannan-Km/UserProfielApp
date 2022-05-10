using UserProfileApp.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using UsersProfileApp.DataStore.Models;
using UsersProfileApp.DataStore.Repository;

namespace UsersProfileApp.Core.Services
{
    public class UserService : IUserService
    {
        private IDataStore _dataStore { get; set; }
        public UserService(IDataStore dataStore)
        {
            _dataStore = dataStore;
        }
        public IEnumerable<Users> GetUsers()
        {
            return _dataStore.GetUsers();
        }

        public void SaveUser(Users user)
        {
            user.Id = Guid.NewGuid();
            _dataStore.SaveUser(user);
        }
    }
}
