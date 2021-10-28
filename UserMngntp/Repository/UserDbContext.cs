using Microsoft.EntityFrameworkCore;
using UserMngntp.Domain;
namespace UserMngntp.Repository
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Linking UserMap with User
            new UserMap(modelBuilder.Entity<User>());
            //Linking UserProfileMap with UserProfile
            new UserProfileMap(modelBuilder.Entity<UserProfile>());
        }
    }
}