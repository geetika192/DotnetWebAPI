using DependencyProg.Model;
namespace DependencyProg.Repository
{
    public interface IEmployeeList
    {
        Employee CreateEmployee(Employee obj);
        int UpdateEmployee(Employee uobj);
        int DeleteEmployee(Employee dobj);
        int SearchEmployee(Employee sobj);
        int FetchEmployee(Employee fobj);
        
    }
}