using System.Collections.Generic;
using EmployeeService.Models;
namespace EmployeeService.Models
{
    public class EmployeeData
    {
        public List<Employee> EmployeeDetails()
        {
            List<Employee> obj= new List<Employee>();
            obj.Add(new Employee{
                phoneno=9255,
                name="Divya"
            });
            obj.Add(new Employee
            {
                phoneno=2555,
                name="Geetika"
            });
            return obj;
        }
        
    }
}