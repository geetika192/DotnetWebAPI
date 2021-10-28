using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace practice
{
    //Applying code first approach. SOLI (Missing) D (Missing)
    public class user   // SRP Single Responsibility 
    {
        public int Id {get;set;}
        public string Username {get;set;}
        public string Age {get;set;}
    }

    public class myContext : DbContext  // Mainly meant with DML operations. Liskov Principle
    {
        public myContext()
        {

        }
        private const string cs="Host=localhost;Port=5432;User ID=postgres;Password=1234;Database=efcorepp;Pooling=true";
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            dbContextOptions.UseNpgsql(cs);
        }

        public DbSet<user> users{get; set;}// For manipulation weuse linq query or linq methods
     
     }
     public  interface  IUserReposiory
     {
         IEnumerable<user> fetchUsers();
         int  AddUser() ;

         int  UpdateUser(int Id, user objuser) ;

         int  DeleteUser(int Id) ;
     }
    //Above interface is synchronous interface and it locl the  main(controller).
    //stromg  recommendation  is do apply task parallel library
    class UserRepository : IUserReposiory
    {
         myContext  objcontext; // now we need migration technique to create database mechanically

         public UserRepository(){
             objcontext =  new myContext();
         }
        IEnumerable<user> IUserReposiory.fetchUsers()
        {
           return objcontext.users.FromSqlRaw("SELECT * from public.products where Id=1").ToList();
         // return objcontext.users.FromSqlInterpolated($"SELECT * from users where id=1").ToList();
        }

        public int AddUser()
        {
              var  std = new user()
            {
                Id = 103,
                Username = "Divya",
                Age="33"
            };
                objcontext.users.Add(std);
                return objcontext.SaveChanges();      
            //objcontext.Add(objuser);  //In-memory
            //return objcontext.SaveChanges(); //Commiting Database
        }

        public int UpdateUser(int Id, user objuser)
        {
            user szuser=objcontext.users.Find(Id);  
            szuser.Age=objuser.Age;
            return objcontext.SaveChanges(); 
        }

        public int DeleteUser(int Id)
        {
           user szuser=objcontext.users.Find(Id);  
           objcontext.Remove(szuser);  //In-memory
           return objcontext.SaveChanges(); 
        }
    }

    class MyApp
     {
        static void Main(string[] args)
        {
            

           IUserReposiory  urep = new UserRepository();  // missing IOC container and DI. user core webapi
           //urep.AddUser();
           //fetch
            var userlist = urep.fetchUsers();
            foreach(user userObj in userlist)
            {
               Console.WriteLine(userObj.Id + " "  +userObj.Username  + "" +userObj.Age )  ;
            }

        }
    }
}