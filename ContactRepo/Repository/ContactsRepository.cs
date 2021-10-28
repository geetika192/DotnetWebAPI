using System.Collections.Generic;
using System.Linq;
using ContactRepo.Models;

namespace ContactRepo.Repository
{
    public class ContactsRepository : IContactsRepository
    {
        List<Contacts> listcontacts=new List<Contacts>();  //listcontacts is an object to perform manipulation
        void IContactsRepository.Add(Contacts contacts)
        {
           listcontacts.Add(contacts);
        }

        Contacts IContactsRepository.Find(int ID)
        {
            var contacts=listcontacts.Where(ctr=>ctr.EmployeeId==ID).SingleOrDefault();
            return contacts;
        }

        List<Contacts> IContactsRepository.GetAll()
        {
            listcontacts.Add(new Contacts{
                EmployeeId=101,
                EmployeeName="Geetika",
                EmployeeMail="geetika192@gmail.com"
            });
            listcontacts.Add(new Contacts{
                EmployeeId=102,
                EmployeeName="Divya",
                EmployeeMail="divya190@gmial.com"
            });
            return listcontacts;
        }

        void IContactsRepository.Remove(int id)
        {
            var contactToRemove=listcontacts.Where(ctr=>ctr.EmployeeId==id).SingleOrDefault();
            if(contactToRemove!=null)
            {
               listcontacts.Remove(contactToRemove);
            }
        }

        void IContactsRepository.Update(Contacts contacts)
        {
             var contactToUpdate=listcontacts.Where(ctr=>ctr.EmployeeId==contacts.EmployeeId).SingleOrDefault();
             if(contactToUpdate!=null)
             {
                 contactToUpdate.EmployeeName=contacts.EmployeeName;
                 contactToUpdate.EmployeeMail=contacts.EmployeeMail;
                
             }
        }
    }
}