using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using userManagement.Service;
using userManagement.Domain;
using AutoMapper;

namespace userManagement.Controllers
{
    [ApiController]
    [Route("taazaa/[controller]")]
    public class UserController:ControllerBase
    {
        IMapper mapper;
        IUserProfileRepository userProfileRepository;
        IUserRepository userRepository;
        public UserController(IUserProfileRepository _userProfileRepository,IUserRepository _userRepository,IMapper _mapper )
        {
            userProfileRepository=_userProfileRepository;
            userRepository=_userRepository;
            mapper=_mapper;
        }
        [HttpPost]
        [Route("CreateUser")]
        public IActionResult createAccount(UserDTO model)
        {
            // User userEntity = new User
            // {
            //     UserName = model.UserName,
            //     EMail = model.Email,
            //     Password = model.Password,
            //     AddedDate = DateTime.UtcNow,
            //     ModifiedDate = DateTime.UtcNow,
            //     IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
            //     userProfile = new UserProfile
            //     {
            //         FirstName = model.FirstName,
            //         LastName = model.LastName,
            //         Address = model.Address,
            //         AddedDate = DateTime.UtcNow,
            //         ModifiedDate = DateTime.UtcNow,
            //         IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
            //     }
            // };
            var userEntity=mapper.Map<User>(model);
            return Ok(userRepository.InsertUser(userEntity));
        }

        [HttpPut("UpdateUser/{id}")]
        
        public IActionResult UpdateAccount(UserDTO model)
        {
            User userEntity = userRepository.GetUser(model.Id);
            userEntity.EMail = model.Email;
            userEntity.ModifiedDate = DateTime.UtcNow;
            userEntity.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            UserProfile userProfileEntity = userProfileRepository.getUserProfile(model.Id);
            userProfileEntity.FirstName = model.FirstName;
            userProfileEntity.LastName = model.LastName;
            userProfileEntity.Address = model.Address;
            userProfileEntity.ModifiedDate = DateTime.UtcNow;
            userProfileEntity.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            userEntity.userProfile = userProfileEntity;
            userRepository.UpdateUser(userEntity);
            return Ok (model);
        }

        [HttpDelete("DeleteUser/{id}")]
        
        public void DeleteAccount(int id)
        {
            UserProfile userProfile = userProfileRepository.getUserProfile(id);
            userRepository.DeleteUser(id);    

        }
        [HttpGet("GetAll")]
        public IActionResult GetAllUSer()
        {
            return Ok(userRepository.GetUsers());
        }


    }
}