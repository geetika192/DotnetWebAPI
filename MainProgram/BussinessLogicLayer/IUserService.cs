using System.Collections.Generic;
using Domain;
namespace BussinessLogicLayer
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        User GetUser(long id);
        long InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(long id);  
    }
}