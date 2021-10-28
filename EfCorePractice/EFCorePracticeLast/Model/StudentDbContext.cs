using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace EFCorePracticeLast.Model
{
    public class StudentDbContext : DbContext
    {
        private const string connectionString = "Host=localhost;Port=5432;User ID=postgres;Password=3238;Database=EFCoreDb;Pooling=true;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }
        public DbSet<Student> std {get;set;}
    }
}