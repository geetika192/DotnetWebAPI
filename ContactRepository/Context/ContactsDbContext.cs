using Microsoft.EntityFrameworkCore;
using ContactRepository.Models;
namespace ContactRepository.Context
{
    public class ContactsDbContext:DbContext
    {
        public DbSet<Contact> contacts{get;set;}
        public ContactsDbContext(DbContextOptions options): base(options)
        {
            
        }

    }
}