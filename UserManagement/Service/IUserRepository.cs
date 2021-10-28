using userManagement.Domain;
using System;
using System.Collections.Generic;

namespace userManagement.Service
{
    public interface IUserRepository
    {
         IEnumerable<User> GetUsers();
        User GetUser(long id);
        int InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(long id);
    }
}