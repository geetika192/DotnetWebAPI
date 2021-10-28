using AutoMapper;
using userManagement.Domain;

namespace UserManagement.Domain
{
    public class Automap:Profile
    {
        public Automap()
        {
            CreateMap<User, UserDTO>()
             .ForMember(dest => dest.FirstName, act => act.MapFrom(src => src.userProfile.FirstName))
                    .ForMember(dest => dest.LastName, act => act.MapFrom(src => src.userProfile.LastName))
                    .ForMember(dest => dest.Address, act => act.MapFrom(src => src.userProfile.Address))
                    .ReverseMap();    
        }
        
    }
}