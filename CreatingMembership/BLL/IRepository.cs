using CreatingMembership.Models;
namespace CreatingMembership.BLL
{
    public interface IUserRepository
    {
         int AddUser(User users);
         bool Login(string name,string pass);
    }
}