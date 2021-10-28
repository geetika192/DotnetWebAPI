using System.Collections.Generic;
using UserManagemment2.Domain;
using UserManagemment2.Repository;
namespace UserManagemment2.Service
{
    public class UserProfileRepository : IUserProfileRepository
    {
        IRepository<UserProfile> userprofileRepository;
        public UserProfileRepository( IRepository<UserProfile> _userprofileRepository)
        {
            userprofileRepository=_userprofileRepository;
        }
        UserProfile IUserProfileRepository.GetUserProfile(int id)
        {
            return userprofileRepository.Get(id);
            
        }

        IEnumerable<UserProfile> IUserProfileRepository.GetUserProfile()
        {
             return userprofileRepository.GetAll();
        }
    }
}