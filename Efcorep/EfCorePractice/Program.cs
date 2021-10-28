using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EfCorePractice
{
    public class Product
    {
        [Key]
       public int Id{get;set;}
       public string Name{get;set;}
    }
    public class ProductContext:DbContext
    {
        private const string cs="Host=localhost;Port=5432;User ID=postgres;Password=1234;Database=practicedb;Pooling=true";
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            dbContextOptions.UseNpgsql(cs);
        }
       public DbSet<Product> products{get;set;} //Table name will be products 

    }
    public class ProductOperation
    {
        ProductContext productContext=new ProductContext();
        public void FetchProduct()
        {
        //   var temp=productContext.products.Where(s => s.Name == "Geetika").FirstOrDefault();
        //   Console.WriteLine(temp.Id);
          try{
          var  descStudents = productContext.products.OrderByDescending(s => s.Name).ToList();

            foreach (var obj in descStudents)
            {
                Console.Write(obj.Name);
                Console.WriteLine();
            }
          }
          catch(Exception e)
          {
              Console.WriteLine(e);
          }
        }
        public void Insert()
        {
            var  std = new Product()
            {
                Id = 103,
                Name = "Divya"
            };
                productContext.products.Add(std);
                productContext.SaveChanges();      
        }
       public void updateProduct(int ID,string n)
        {
            var productss = productContext.products
                  .Where(s => s.Id == ID)
                  .FirstOrDefault<Product>();
            productss.Name=n;
            productContext.SaveChanges();
            Console.WriteLine("Update successfully !!!!");
        }
        public void Delete(int ID)
        {
            var std=productContext.products.Find(ID);
            if(std!=null)
            {
                productContext.products.Remove(std);
                productContext.SaveChanges();
            }
        }

}
    class Program
    {
        public static void Main()
        {
           ProductOperation productOperation=new ProductOperation();
           productOperation.FetchProduct();
            //productOperation.Insert();
            //productOperation.updateProduct(102,"deep");
            //productOperation.Delete(101);
        }
    }
}
