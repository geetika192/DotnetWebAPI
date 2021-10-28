using System.Collections.Generic;
using System.Threading.Tasks;
using ContactRepository.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ContactRepository.Models;

namespace ContactRepository.Repository
{
    public class ContactsRepository:IContactsRepository
    {
        ContactsDbContext contactsDbContext;
        public ContactsRepository(ContactsDbContext _contactsDbContext)
        {
            contactsDbContext=_contactsDbContext;
        }

        async Task IContactsRepository.Add(Contact item)
        {
           await contactsDbContext.AddAsync(item);
           await contactsDbContext.SaveChangesAsync();
        }

        async Task<Contact> IContactsRepository.Find(int key)
        {
            return await contactsDbContext.contacts.SingleOrDefaultAsync(ctr => ctr.Id==key);
            
        }

        async Task<IEnumerable<Contact>> IContactsRepository.GetAll()
        {
            return await contactsDbContext.contacts.ToListAsync();
        }
    }
}