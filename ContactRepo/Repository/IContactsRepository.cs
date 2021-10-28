using ContactRepo.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactRepo.Repository
{
    public interface IContactsRepository
    {
         void Add(Contacts contacts);
         List<Contacts> GetAll();
         Contacts Find(int ID);  //Searching a record by id returing as Contacts
         void Update(Contacts contacts);  //We can update a record by id or by mail 
         void Remove(int id);  //We are removing the record by id  or returning as a void 

    }
}