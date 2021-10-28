using Microsoft.EntityFrameworkCore;
using UserManagemment2.Domain;
using System;
namespace UserManagemment2.Repository
{
    public class ApplicationContext : DbContext
    {
        
        
        public ApplicationContext(DbContextOptions options):base (options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Linking Between User(Model) and UserMap(Mapper)
             new UserMap(modelBuilder.Entity<User>());
             //Linking Between UserProfile(Model) and UserMap(Mapper)
              new UserProfileMap(modelBuilder.Entity<UserProfile>());
              modelBuilder.Entity<User>().HasData(new User{Id=123,UserName="sandeep",Password="test123",Email="sandeep@gmail.com",AddedDate= DateTime.UtcNow,IPAddress="56678",ModifiedDate= DateTime.UtcNow});
              modelBuilder.Entity<User>().HasData(new User{Id=163,UserName="sandeep karan",Password="test789",Email="sandeep23@gmail.com",AddedDate= DateTime.UtcNow,IPAddress="56678",ModifiedDate= DateTime.UtcNow});
            
        }
    }
}