using System.Collections.Generic;
using UserManagemment2.Domain;
namespace UserManagemment2.Service
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