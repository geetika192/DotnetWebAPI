using userManagement.Domain;
namespace userManagement.Service
{
    public interface IUserProfileRepository
    {
        UserProfile getUserProfile(int id);
    }
}