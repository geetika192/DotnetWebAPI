using DependencyInjection1.Model;
using DependencyInjection1.Repository;
namespace DependencyInjection1.Repository
{
    public class EmployeeList:IEmployeeList
    {
       public int CreateEmployee(Employee temp)
       {
          return 1;
       }
    }
}