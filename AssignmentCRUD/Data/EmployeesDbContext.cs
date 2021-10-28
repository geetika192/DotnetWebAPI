using Microsoft.EntityFrameworkCore;
using AssignmentCRUD.Models;

namespace AssignmentCRUD.Data
{
    public class EmployeesDbContext : DbContext
    {
        public EmployeesDbContext(DbContextOptions dbContext) : base(dbContext)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new EmployeesMap(modelBuilder.Entity<Employees>());
        }

        public DbSet<Employees> dbEmployees{get; set;}
    }
}