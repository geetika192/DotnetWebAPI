using CreatingMembership.Models;
using CreatingMembership.Data;
using System.Linq;

namespace CreatingMembership.BLL
{
    public class UserRepository : IUserRepository
    {
        ApplicationDbContext applicationDbContext1;
        public UserRepository(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext1=_applicationDbContext;
        }
        int IUserRepository.AddUser(User users)
        {
             applicationDbContext1.Add(users);
             int temp=applicationDbContext1.SaveChanges();
             return temp;
        }

        bool IUserRepository.Login(string name, string pass)
        {
             var temp=applicationDbContext1.users.FirstOrDefault(ctr=>ctr.UserName==name&&ctr.Password==pass);
             if(temp!=null)
             {
                 return true;
             }
            return false;
        

        }
    }
}