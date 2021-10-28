using DependencyProg.Model;
using DependencyProg.Repository;
using  Microsoft.AspNetCore.Mvc;
namespace DependencyProg.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class EmployeeController:ControllerBase
    {
        IEmployeeList listg;
        public EmployeeController(IEmployeeList ilist)
        {
            listg=ilist;
        }
        [HttpPost("Create")]
        public Employee CreateEmployeeData(Employee temp)
        {
            var t=listg.CreateEmployee(temp);
            return temp;
        }
  
         [HttpPost("Delete")]
        public Employee DeleteEmployeeData(Employee temp)
        {
            var t=listg.DeleteEmployee(temp);
            if (t==0)
            {
                
            }
            return temp;
        }
         [HttpPost("Search")]
        public Employee SearchEmployeeData(Employee temp)
        {
            var t=listg.SearchEmployee(temp);
            if (t==0)
            {
                
            }
            return temp;
        }
         [HttpPost("Fetch")]
        public Employee FetchEmployeeData(Employee temp)
        {
            var t=listg.FetchEmployee(temp);
            if (t==0)
            {
                
            }
            return temp;
        }
          [HttpPost("Update")]
        public Employee UpadateEmployeeData(Employee temp)
        {
            var t=listg.UpdateEmployee(temp);
            if (t==0)
            {
                
            }
            return temp;
        }

   
    }
}