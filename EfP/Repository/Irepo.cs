using System.Collections.Generic;
using EfP.Domain;

namespace EfP.Repository
{
    public interface Irepo
    {
         int Add_User(User user);
         void Update_User();
         int Delete_User(int Id);
         User Search_user_By_User_Id(int Id);
        IEnumerable<User> Get_User_List();

    }
}