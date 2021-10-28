using contactRepop.Models;
using System.Collections.Generic;

namespace contactRepop.ContactRepository
{
    public interface IContactsRepository
    {
        void AddEmployee(Employee employee); 
        void Update(Employee employee);
        void Remove(int id);
        List<Employee> GetAll();
        Employee Find(int id);

    }
}