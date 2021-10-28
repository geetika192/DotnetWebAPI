using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserManagemment2.Service;
using UserManagemment2.Domain;

namespace UserManagemment2.Controllers
{
    [ApiController]
    [Route("Taazaa/[controller]")]
    public class Usercontroller : ControllerBase
    {
        IUserRepository userRepository;

        IUserProfileRepository userProfileRepository;
        public Usercontroller(IUserRepository _userRepository, IUserProfileRepository _userProfileRepository)
        {
            userRepository = _userRepository;
            userProfileRepository = _userProfileRepository;
        }
        [HttpPost]
        [Route("AddUser")]
        public IActionResult CreateAccount(UserDTO model)
        {
            User userEntity = new User
            {
                UserName = model.UserName,
                Email = model.Email,
                Password = model.Password,
                AddedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow,
                IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                userProfile = new UserProfile
                {
                    FirstName = model.First,
                    LastName = model.LastName,
                    Address = model.Address,
                    AddedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
                }
            };
            return Ok(userRepository.InsertUser(userEntity));
        }
        [HttpPut("UpdateUser/{id}")]
        public IActionResult UpdatAccount(UserDTO model)
        {
            
            User userEntity =  userRepository.GetUser(model.Id);
            userEntity.Email = model.Email;
            userEntity.ModifiedDate = DateTime.UtcNow;
            userEntity.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            UserProfile userProfileEntity = userProfileRepository.GetUserProfile(model.Id);
            userProfileEntity.FirstName = model.First;
            userProfileEntity.LastName = model.LastName;
            userProfileEntity.Address = model.Address;
            userProfileEntity.ModifiedDate = DateTime.UtcNow;
            userProfileEntity.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            userEntity.userProfile = userProfileEntity;
            userRepository.UpdateUser(userEntity);
            return Ok(model);
        }
        [HttpDelete("Delete/{id}")]
        public  IActionResult DeleteUser(int id)
        {
            //UserProfile userProfile = userProfileRepository.GetUserProfile(id);
            userRepository.DeleteUser(id); 
             return Ok(id);

        }
        //[HttpGet("Users/{int}")]
         [HttpGet("Users")]
        public IActionResult GetUser(int id)
        {
            
            return Ok (userRepository.GetUser(id));    

           // return Ok(obj.UserName+ obj.Email);
                
        }
         [HttpGet("UsersProfile")]
        public IActionResult GetUserProfile(int id)
        {
            return Ok(userProfileRepository.GetUserProfile(id));
        }
         [HttpGet("GetAllUsers")]
        public IActionResult GetAllUser()
        {
            return Ok(userRepository.GetUsers());
        }
         [HttpGet("GetAllUserProfile")]
         public IActionResult GetAllUserProfile()
        {
            return Ok(userProfileRepository.GetUserProfile());
        }
    }
}
