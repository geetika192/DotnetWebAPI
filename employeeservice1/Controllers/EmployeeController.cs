using Microsoft.AspNetCore.Mvc;
using employeeservice1.Model;
namespace employeeservice1.Controllers
{
     [ApiController]
     [Route("[controller]")]
    public class EmployeeController  : ControllerBase
    {
        [HttpPost("Create")]
        public Employee CreateEmployee(Employee empobj)
        {
            return empobj;
        }
    }
}