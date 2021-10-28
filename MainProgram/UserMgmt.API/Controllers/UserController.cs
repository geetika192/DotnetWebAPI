using System;
using BussinessLogicLayer;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace UserMgmt.API.Controllers
{
    [ApiController]
    [Route("Taazaa/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly IUserProfileService userProfileService;

        public UserController(IUserService userService, IUserProfileService userProfileService)
        {
            this.userService = userService;
            this.userProfileService = userProfileService;
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
                UserProfile = new UserProfile
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    AddedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
                }
            };
            return Ok(userService.InsertUser(userEntity));
        }
         [HttpPut("UpdateUser/{id}")]
        public IActionResult UpdatAccount(UserDTO model)
        {
            
            User userEntity =  userService.GetUser(model.Id);
            userEntity.Email = model.Email;
            userEntity.ModifiedDate = DateTime.UtcNow;
            userEntity.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            UserProfile userProfileEntity = userProfileService.GetUserProfile(model.Id);
            userProfileEntity.FirstName = model.FirstName;
            userProfileEntity.LastName = model.LastName;
            userProfileEntity.Address = model.Address;
            userProfileEntity.ModifiedDate = DateTime.UtcNow;
            userProfileEntity.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            userEntity.UserProfile = userProfileEntity;
            userService.UpdateUser(userEntity);
            return Ok(model);
        }
    }
}