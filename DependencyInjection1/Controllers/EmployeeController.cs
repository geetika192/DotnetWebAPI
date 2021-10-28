using Microsoft.AspNetCore.Mvc;
using DependencyInjection1.Repository;
using DependencyInjection1.Model;
namespace DependencyInjection1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController: ControllerBase
    {
        
        IEmployeeList list1;
        public EmployeeController(IEmployeeList temp)
        {
            list1=temp;
        }
        [HttpPost]
        public Employee createEmployeeData(Employee obj)
        {
             var t=list1.CreateEmployee(obj);
             if(t==1)
             {

             }              
             return obj;

        }
    }
}