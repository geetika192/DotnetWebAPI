using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;  
using System;  
using CURDOperationA.Models;
using System.Collections.Generic;  
namespace CURDOperationA.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)  
        {  
  
        }  
        protected override void OnModelCreating(ModelBuilder builder)  
        {  
            base.OnModelCreating(builder);  
        }  
        public DbSet<Person> Persons { get; set; } 
    }
}