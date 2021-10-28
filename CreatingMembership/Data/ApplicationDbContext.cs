using Microsoft.EntityFrameworkCore;
using CreatingMembership.Models;

namespace CreatingMembership.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<User> users{get;set;}
        public ApplicationDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserMap(modelBuilder.Entity<User>());
        }
    }
}