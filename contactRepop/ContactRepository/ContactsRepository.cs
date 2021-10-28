using contactRepop.Models;
using System.Linq;
using System.Collections.Generic;

namespace contactRepop.ContactRepository
{
    public class ContactsRepository : IContactsRepository
    {
        List<Employee> list=new List<Employee>();
        void IContactsRepository.AddEmployee(Employee employee)
        {
            list.Add(employee);
        }

        Employee IContactsRepository.Find(int id)
        {
            var contactToFind=list.Where(ctr=>ctr.EmployeeID==id).SingleOrDefault();
             return(contactToFind);
        }

        List<Employee> IContactsRepository.GetAll()
        {
           return list;
        }

        void IContactsRepository.Remove(int id)
        {
           var contactToRemove=list.Where(ctr=>ctr.EmployeeID==id).SingleOrDefault();
            if(contactToRemove!=null)
            {
               list.Remove(contactToRemove);
            }
        }

        void IContactsRepository.Update(Employee employee)
        {
            var contactToUpdate=list.Where(ctr=>ctr.EmployeeID==employee.EmployeeID).SingleOrDefault();
        }
    }
}