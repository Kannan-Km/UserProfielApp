using System;
using System.Collections.Generic;
using System.Text;
using UsersProfileApp.DataStore.Models;

namespace UserProfileApp.Core.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<Users> GetUsers();

        void SaveUser(Users user);
    }
}
