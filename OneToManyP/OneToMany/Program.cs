using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EmpDepartmentRelation
{
     class Department
    {
        public int DepartmentID{get;set;}
        public string DepartmentName{get;set;}
         public virtual ICollection<Employee> Employee { get; set; } //navigation
    }

    class Employee
    {
        public int EmployeeID{get;set;}
        public string EmployeeName{get;set;}
        public int EmployeeSalary{get;set;}
        public virtual Department Department{get;set;}//navigation
    }

    class ManagementDbContext:DbContext
    {
      public DbSet<Employee> employees{get;set;}
      public DbSet<Department> departments{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;User ID=postgres;Password=1234;Database=Assigment;Pooling=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DepartmentID);
                entity.Property(e => e.DepartmentName).IsRequired();
            });
            modelBuilder.Entity<Employee>(entity =>
           {
               entity.HasKey(e => e.EmployeeID);
               entity.Property(e => e.EmployeeName).IsRequired();
               entity.Property(e =>e.EmployeeSalary).IsRequired();
               entity.HasOne(d => d.Department).WithMany(p => p.Employee);
           });
        }
    }
    class Program
    {
        static void Main()
        {
        //     Department department = new Department();
        //    department.DepartmentID = 2;
        //     department.DepartmentName = "IT"; 
            ManagementDbContext context = new ManagementDbContext();
        //    context.Add(department);
        //   context.SaveChanges();

        //     context.employees.Add(new Employee  
        //     {
        //         EmployeeID = 102,
        //         EmployeeName = "DeVilliers",
        //         EmployeeSalary = 85000,
        //         Department = department
        //     });
        //     context.SaveChanges(); 
            Console.WriteLine("Please enter Employee ID to search");
            int ID  = Convert.ToInt32(Console.ReadLine());
            var record = context.employees.Include(e => e.Department).Select(e => new
                      {
                       empID = e.EmployeeID,
                       empName = e.EmployeeName,
                       empSalary = e.EmployeeSalary,
                       empDepartment = e.Department.DepartmentName
                       }).Where(e=>e.empID ==ID);
            foreach (var emp in record)
            {
                Console.WriteLine("Employee ID : "+emp.empID+"\nEmployee Name : "+emp.empName+"\nEmployee Department: "+emp.empDepartment+" "+emp.empSalary);
            }
        }
    }
}