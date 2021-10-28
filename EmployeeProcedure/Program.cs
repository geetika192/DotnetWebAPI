using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace EmployeeProcedure
{
     public class Employee  // SRP Single Responsibility 
    {
        [Key]
        public int Id { get; set; }
        public string empname { get; set; }
    }
     public class UserContext : DbContext
    {
        public UserContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)   // Open close principle
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;User ID=postgres;Password=1234;Database=DatabaseDay47;Pooling=true;");
        }

        public DbSet<Employee> employees { get; set; }// For manipulation weuse linq query or linq methods

    }
    public interface IUserRepository
    {
      
        int AddUser(Employee emp);

    }
    class UserRepository : IUserRepository
    {
          UserContext objcontext;
          public UserRepository()
          {
              objcontext=new UserContext();
          }
        int IUserRepository.AddUser(Employee employee)
        {
            var name = new SqlParameter("ename",employee.empname); //ename proceudure variable
           objcontext.Database.ExecuteSqlRaw("call addemployee( '"+name.Value+"')"); //call
           //objcontext.employees.FromSqlRaw
          return 1;
        }

       
    class Program
    {
        static void Main(string[] args)
        {
               IUserRepository urep = new UserRepository();
              
                Employee obj=new Employee();
                obj.empname="Deepak";
               urep.AddUser(obj);
        }
    }
}
}
