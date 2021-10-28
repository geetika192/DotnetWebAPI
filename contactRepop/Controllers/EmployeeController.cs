using Microsoft.AspNetCore.Mvc;
using contactRepop.ContactRepository;
using contactRepop.Models;
namespace contactRepop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController: ControllerBase
    {
         IContactsRepository contactsRepository;
        public EmployeeController(IContactsRepository con)
        {
            contactsRepository=con;
        }
        [HttpPost("AddEmployee")]
        public IActionResult CreateEmployee(Employee emp)
        {
           contactsRepository.AddEmployee(emp);
           return Ok("record is added");
        }
        [HttpGet("Find")]
        public IActionResult FindEmployee(int id)
        {
           var temp=contactsRepository.Find(id);
           return Ok(temp);
        }
        [HttpGet("showAll")]
        public IActionResult ShowAll()
        {
           var temp1=contactsRepository.GetAll();
           return Ok(temp1);
        }
        [HttpDelete]
        public IActionResult RemoveEmployee(int id)
        {
           contactsRepository.Remove(id);
           return Ok("Record is Removed");
        }
        [HttpPut("update")]
        public IActionResult UpdateRecord(Employee employee)
        {
           contactsRepository.Update(employee);
           return Ok("Record is updated");
        }


    }
}