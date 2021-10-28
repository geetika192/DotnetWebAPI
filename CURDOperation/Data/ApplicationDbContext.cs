using Microsoft.EntityFrameworkCore;
using CURDOperation.Models;

namespace CURDOperation.Data
{
    public class ApplicationDbContext:DbContext
    {
            public ApplicationDbContext(DbContextOptions options) : base(options)
            {
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                new CustomerMap(modelBuilder.Entity<Customer>());
            }
        }
    }