using AutoMapper;
namespace CreatingMembership.Models
{
    public class AutoMapperProfile:Profile
    {
      public AutoMapperProfile()
      {
          CreateMap<UserDTO,User>();
      }  
    }
}