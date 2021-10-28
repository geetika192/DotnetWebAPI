using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CURDOperationA.Service;
using CURDOperationA.Repository;
using CURDOperationA.Models; 

namespace CURDOperationA.Controllers
{
   [Route("api/[controller]")]  
    [ApiController]  
    public class PersonDetailsController : ControllerBase  
    {  
        private readonly PersonService _personService;  
  
        private readonly IPersonRepository<Person> _Person;  
  
        public PersonDetailsController(IPersonRepository<Person> Person, PersonService ProductService)  
        {  
            _personService = ProductService;  
            _Person = Person;  
  
        }  
        //Add Person  
        [HttpPost("AddPerson")]  
        public async Task<Object> AddPerson([FromBody] Person person)  
        {  
            try  
            {  
                await _personService.AddPerson(person);  
                return true;  
            }  
            catch (Exception)  
            {  
  
                return false;  
            }  
        }  
        //Delete Person  
        [HttpDelete("DeletePerson")]  
        public bool DeletePerson(string UserEmail)  
        {  
            try  
            {  
                _personService.DeletePerson(UserEmail);  
                return true;  
            }  
            catch (Exception)  
            {  
                return false;  
            }  
        }  
        //Delete Person  
        [HttpPut("UpdatePerson")]  
        public bool UpdatePerson(Person Object)  
        {  
            try  
            {  
                _personService.UpdatePerson(Object);  
                return true;  
            }  
            catch (Exception)  
            {  
                return false;  
            }  
        }  
        //GET All Person by Name  
       /*  [HttpGet("GetAllPersonByName")]  
        public Object GetAllPersonByName(string UserEmail)  
        {  
            var data = _personService.GetPersonByUserName(UserEmail);
            return data;  
            
        }  
  
        //GET All Person  
        [HttpGet("GetAllPersons")]  
        public Object GetAllPersons()  
        {  
            var data = _personService.GetAllPersons();  
            return data;
            
        }   */
}
}