using userManagement.Domain;
using userManagement.Repository;
namespace userManagement.Service
{
    public class UserProfileRepository : IUserProfileRepository
    {
        IRepository<UserProfile> userProfileRepository;
        public UserProfileRepository(IRepository<UserProfile> _userProfileRepository)
        {
            userProfileRepository=_userProfileRepository;
        }
        UserProfile IUserProfileRepository.getUserProfile(int id)
        {
            return userProfileRepository.Get(id);
        }
    }
}