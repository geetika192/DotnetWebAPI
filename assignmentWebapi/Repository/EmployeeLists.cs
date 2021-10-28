using DependencyProg.Model;
using System.Collections.Generic;
namespace DependencyProg.Repository
{
    public class EmployeeList:IEmployeeList
    {
        List<Employee> lists;
         public EmployeeList()
        {
            lists = new List<Employee>();
        }
        public Employee CreateEmployee(Employee obj)
        {
            lists.Add(obj);
            return obj;
        }
        public int UpdateEmployee(Employee uobj)
        {
            return 1;
        }
        public int DeleteEmployee(Employee dobj)
        {
            return 1;
        }
        public int SearchEmployee(Employee sobj)
        {
            return 1;
        }
        public int FetchEmployee(Employee fobj)
        {
            return 1;
        }
    }