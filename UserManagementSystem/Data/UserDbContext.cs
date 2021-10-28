using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models;

namespace UserManagementSystem.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserMapper(modelBuilder.Entity<User>());
        }
        public DbSet<User> users{get;set;}
    }
}