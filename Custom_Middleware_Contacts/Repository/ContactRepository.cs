using Custom_Middleware_Contacts.Models;
using Custom_Middleware_Contacts.Context;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Custom_Middleware_Contacts.Repository
{
    public class ContactRepository:IContactRepository
    {
         ContactsDBContext _context;
         public ContactRepository()
         {
             
         }
        public ContactRepository(ContactsDBContext context)
        {
            _context=context;
        }
        public async Task Add(Contacts item)
        {            
            await _context.AddAsync(item);
            await _context.SaveChangesAsync();
        }
          public async Task<IEnumerable<Contacts>> GetAll()
        {
            return await _context.contacts.ToListAsync();
        }

        public bool CheckValidUserKey(string reqkey)
        {
            var userkeyList = new List<string>
            {
                "28236d8ec201df516d0f6472d516d72d",
                "38236d8ec201df516d0f6472d516d72c",
                "48236d8ec201df516d0f6472d516d72b"
            };

            if (userkeyList.Contains(reqkey))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<Contacts> Find(string key)
        {
            return await _context.contacts
                .Where(e => e.MobilePhone.Equals(key))
                .SingleOrDefaultAsync();
        }       

        public async Task Remove(string Id)
        {
            var itemToRemove = await _context.contacts.SingleOrDefaultAsync(r => r.MobilePhone == Id);
            if (itemToRemove != null)
            {
                _context.Remove(itemToRemove);
                await _context.SaveChangesAsync();
            }
        }

        public async Task Update(Contacts item)
        {            
            var itemToUpdate = await _context.contacts.SingleOrDefaultAsync(r => r.MobilePhone == item.MobilePhone);
            if (itemToUpdate != null)
            {
                itemToUpdate.FirstName = item.FirstName;
                itemToUpdate.LastName = item.LastName;
                itemToUpdate.MobilePhone = item.MobilePhone;
                await _context.SaveChangesAsync();
            }
        }

    }
    
}