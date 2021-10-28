using userManagement.Domain;
using Microsoft.EntityFrameworkCore;
namespace userManagement.Repository
{
    public class AppilcationContext:DbContext
    {
        
        public AppilcationContext(DbContextOptions options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // here we are linking building between user and usermap and for context we use onconfigure
            new UserMap(modelBuilder.Entity<User>());
            new UserProfileMap(modelBuilder.Entity<UserProfile>());

            //Seeding in user table 
            modelBuilder.Entity<User>().HasData(new User{Id=123,UserName="sandeep",Password="test123",EMail="sandeep@gmail.com",AddedDate= DateTime.UtcNow,IPAddress="56678",ModifiedDate= DateTime.UtcNow});
              modelBuilder.Entity<User>().HasData(new User{Id=163,UserName="sandeep karan",Password="test789",EMail="sandeep23@gmail.com",AddedDate= DateTime.UtcNow,IPAddress="56678",ModifiedDate= DateTime.UtcNow});
        }
    }
}