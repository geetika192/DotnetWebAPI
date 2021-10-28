using System.Collections.Generic;
using EfP.Context;
using EfP.Domain;
using System.Linq;

namespace EfP.Repository
{
    public class Repo : Irepo
    {
        UDbContext uDbContext=new UDbContext();
        int Irepo.Add_User(User user)
        {
            uDbContext.users.Add(user);
            int result=uDbContext.SaveChanges();
            return result;
        }

        int Irepo.Delete_User(int Id)
        {
            User Get_record=uDbContext.users.Find(Id);
            if(Get_record==null)
            {
                return 0;
            }
            return 1;
        }

        IEnumerable<User> Irepo.Get_User_List()
        {
            var List_Of_Records=uDbContext.users.ToList();
            if(List_Of_Records==null)
            {
                return null;
            } 
            return List_Of_Records;
        }

        User Irepo.Search_user_By_User_Id(int Id)
        {
            User Get_Single_Record=uDbContext.users.Where(ctr=>ctr.UserID==Id).Single();
            if(Get_Single_Record==null)
            {
                return null;
            }
            return Get_Single_Record;
        }

        void Irepo.Update_User()
        {
            uDbContext.SaveChanges();
            
        }
    }
}