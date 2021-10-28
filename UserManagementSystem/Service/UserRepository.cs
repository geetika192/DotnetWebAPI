using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Data;
namespace UserManagementSystem.Service
{
    public class UserRepository
    {
        UserDbContext userDbContext;
        public UserRepository(UserDbContext _userDbContext)
        {
            userDbContext = _userDbContext;
        }
    }
}