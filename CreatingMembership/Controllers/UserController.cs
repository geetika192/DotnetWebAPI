using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CreatingMembership.Data;
using CreatingMembership.BLL;
using CreatingMembership.Models;
using AutoMapper;

namespace CreatingMembership.Controllers
{
    [ApiController]
    [Route("Taazaa/[controller]")]
    public class UserController:ControllerBase
    {
        IUserRepository repository;
        IMapper mapper;
        public UserController(IUserRepository _repository,IMapper _mapper)
        {
            repository=_repository;
            mapper=_mapper;
        }
        [HttpPost("AddMembership")]
        public IActionResult CreatingMembership(UserDTO userdto)
        {
            var usermap=mapper.Map<User>(userdto);
         // User obj=new User();
        //   obj.Id=user.Id;
        //   obj.Password=user.Password;
        //   obj.UserName=user.UserName;
        //   obj.Age=user.Age;

           repository.AddUser(usermap);
            return Ok(userdto.UserName);
        }
        [HttpPost("login")]
        public IActionResult LoginUser(LoginDTO loginDTO)
        {
            var temp=repository.Login(loginDTO.UserName,loginDTO.Password);
            if(temp==true)
            {
                return Ok("True");
            }
            return Ok("False");
        }
    }
}