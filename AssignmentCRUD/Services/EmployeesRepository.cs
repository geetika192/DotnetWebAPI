using System;
using System.Linq;
using AssignmentCRUD.Models;
using AssignmentCRUD.Data;

namespace AssignmentCRUD.Services
{
    public class EmployeesRepository : IEmployeesRepository
    {
        EmployeesDbContext employeesDbContext;
        public EmployeesRepository(EmployeesDbContext _employeesDbContext)
        {
            employeesDbContext = _employeesDbContext;
        }
        void IEmployeesRepository.EmpAdd(Employees emp)
        {
            employeesDbContext.Add(emp);
            employeesDbContext.SaveChanges();
        }

        void IEmployeesRepository.EmpDelete(int Id)
        {
            var delObj = employeesDbContext.dbEmployees.FirstOrDefault(x=>x.EmpId==Id);
            if(delObj == null)
            {
                throw new NullReferenceException();
            }
            employeesDbContext.dbEmployees.Remove(delObj);
            employeesDbContext.SaveChanges();
        }

        IQueryable<Employees> IEmployeesRepository.EmpGetAll()
        {
            var getObj = employeesDbContext.dbEmployees.AsQueryable();
            return getObj;
        }

        Employees IEmployeesRepository.EmpSearch(int Id)
        {
            var serObj = employeesDbContext.dbEmployees.FirstOrDefault(x=>x.EmpId==Id);
            if(serObj == null)
            {
                throw new NullReferenceException();
            }
            return serObj;
        }

        void IEmployeesRepository.EmpUpdate(int Id, Employees emp)
        {
            var updObj = employeesDbContext.dbEmployees.FirstOrDefault(x=>x.EmpId==Id);
            if(updObj == null)
            {
                throw new NullReferenceException();
            }
            updObj.EmpName = emp.EmpName;
            updObj.EmpSalary = emp.EmpSalary;
            employeesDbContext.SaveChanges();
        }
    }
}