using Domain;

namespace BussinessLogicLayer
{
    public interface IUserProfileService
    {
       UserProfile GetUserProfile(long id);  
    }
}