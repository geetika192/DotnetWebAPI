using  Microsoft.AspNetCore.Mvc;
 using EmployeeService.Models;
 using System.Collections.Generic;

namespace EmployeeService.Controllers
{
    [Route("[controller]")]
    public class EmployeeController:ControllerBase

    {
        [HttpGet("info")]
        public List<Employee> Detail()
        {
            EmployeeData obj = new EmployeeData();
            List<Employee> temp =obj.EmployeeDetails();
            return temp;
        }
       
    }
}