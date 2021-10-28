using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ContactRepository.Context;
using ContactRepository.Models;
using ContactRepository.Repository;

namespace ContactRepository.Controllers
{
     [ApiController]
    [Route("/Taazaa[controller]")]
    public class ContactController:ControllerBase
    {
        IContactsRepository contactsRepository;
        public ContactController( IContactsRepository _contactsRepository)
        {
            contactsRepository=_contactsRepository;
        }
        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> AddContact(Contact contact)
        {
           if(contact==null)
           {
              return BadRequest();
           }
           await contactsRepository.Add(contact);
           return Ok(contact);
        }
       /*  [HttpGet]
        [Route("Find")]
         public async IActionResult ShowAll()
        {
            
        }
         [HttpGet]
        [Route("Find")]
         public IActionResult FindContact()
        {
            
        } */
    }
}