using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CURDOperation.Data;
using CURDOperation.Models;
using Microsoft.AspNetCore.Http;  


namespace CURDOperation.Controllers
{
   public class CustomerController : Controller  
    {  
        private ApplicationDbContext context;  
  
        public CustomerController(ApplicationDbContext context)  
        {  
            this.context = context;  
        }  
        [HttpPost("Add")]  
        public IActionResult Index()  
        {  
            IEnumerable<Customer> model = context.Set<Customer>().ToList().Select(s => new Customer  
            {  
                Id= s.Id,  
                Name = $"{s.Name} {s.LastName}",  
                MobileNo = s.MobileNo,  
                Email = s.Email  
            });  
            return View("Index", model);  
        }  
  
        [HttpGet("update")]  
        public IActionResult AddEditCustomer(long? id)  
        {  
            Customer model = new Customer();  
            if (id.HasValue)  
            {  
                Customer customer = context.Set<Customer>().SingleOrDefault(c => c.Id == id.Value);  
                if (customer != null)  
                {  
                    model.Id = customer.Id;  
                    model.Name = customer.Name;  
                    model.LastName = customer.LastName;  
                    model.MobileNo = customer.MobileNo;  
                    model.Email = customer.Email;  
                }  
            }  
            return PartialView("~/Views/Customer/_AddEditCustomer.cshtml", model);  
        }  
  
        [HttpPost("updateCustomer")]  
        public ActionResult AddEditCustomer(long? id, Customer model)  
        {  
            try  
            {  
                if (ModelState.IsValid)  
                {  
                    bool isNew = !id.HasValue;  
                    Customer customer = isNew ? new Customer  
                    {  
                        AddedDate = DateTime.UtcNow  
                    } : context.Set<Customer>().SingleOrDefault(s => s.Id == id.Value);  
                    customer.Name = model.Name;  
                    customer.LastName = model.LastName;  
                    customer.MobileNo = model.MobileNo;  
                    customer.Email = model.Email;  
                    customer.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();  
                    customer.ModifiedDate = DateTime.UtcNow;  
                    if (isNew)  
                    {  
                        context.Add(customer);  
                    }  
                    context.SaveChanges();  
                }  
            }  
            catch (Exception ex)  
            {  
                throw ex;  
            }  
            return RedirectToAction("Index");  
        }  
  
        [HttpDelete("delete")]  
        public IActionResult DeleteCustomer(long id)  
        {  
            Customer customer = context.Set<Customer>().SingleOrDefault(c => c.Id == id);  
            Customer model = new Customer  
            {  
                Name = $"{customer.Name} {customer.LastName}"  
            };  
            return PartialView("~/Views/Customer/_DeleteCustomer.cshtml", model);  
        }  
        /* [HttpPost]  
         public IActionResult DeleteCustomer(long id, FormCollection form)  
        {  
            Customer customer = context.Set<Customer>().SingleOrDefault(c => c.Id == id);  
            context.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;  
            context.SaveChanges();  
            return RedirectToAction("Index");  
        }    */
}
}
