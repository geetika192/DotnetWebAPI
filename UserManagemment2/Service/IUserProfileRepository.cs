using System.Collections.Generic;
using UserManagemment2.Domain;
using UserManagemment2.Repository;
namespace UserManagemment2.Service
{
    public interface IUserProfileRepository
    {
         UserProfile GetUserProfile(int id);
          IEnumerable<UserProfile> GetUserProfile();
    }
}