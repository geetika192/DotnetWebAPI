using Custom_Middleware_Contacts.Models;
using Microsoft.EntityFrameworkCore;
namespace Custom_Middleware_Contacts.Context
{
    public class ContactsDBContext:DbContext
    {
       public DbSet<Contacts> contacts{get;set;}
        public ContactsDBContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            
        }
        public ContactsDBContext()
        {

        }
    }
}