using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AssignmentCRUD.Services;
using AssignmentCRUD.Models;
using AssignmentCRUD.Data;

namespace AssignmentCRUD.Controllers
{
    [ApiController]
    [Route("crudApp/[controller]")]
    public class EmployeesController : ControllerBase
    {
        IEmployeesRepository employeesRepository;
        public EmployeesController(IEmployeesRepository _employeesRepository)
        {
            employeesRepository = _employeesRepository;
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddRecords(Employees emp)
        {
            employeesRepository.EmpAdd(emp);
            return Ok("Record is Added!!");
        }

        [HttpPut]
        [Route("update/{Id}")]
        public IActionResult UpdRecords(int Id, Employees emp)
        {
            employeesRepository.EmpUpdate(Id, emp);
            return Ok("Record is Updated!!");
        }

        [HttpGet]
        [Route("search/{Id}")]
        public IActionResult SerRecords(int Id)
        {
            var temp = employeesRepository.EmpSearch(Id);
            return Ok(temp);
        }

        [HttpDelete]
        [Route("delete/{Id}")]
        public IActionResult DelRecords(int Id)
        {
            employeesRepository.EmpDelete(Id);
            return Ok("Record is Deleted!!");
        }

        [HttpGet]
        [Route("getAll")]
        public IActionResult GetAllRecords()
        {
            var temp = employeesRepository.EmpGetAll();
            return Ok(temp);
        }
        
    }
}