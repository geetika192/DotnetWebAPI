using System;
using System.Collections.Generic;
using System.Linq;
using AssignmentCRUD.Models;
namespace AssignmentCRUD.Services
{
    public interface IEmployeesRepository
    {
        void EmpAdd(Employees emp);
        void EmpUpdate(int Id, Employees emp);
        Employees EmpSearch(int Id);
        void EmpDelete(int Id);
        IQueryable<Employees> EmpGetAll();

    }
}