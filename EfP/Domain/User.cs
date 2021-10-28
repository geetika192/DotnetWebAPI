using System;
using System.ComponentModel.DataAnnotations;

namespace EfP.Domain
{
    public class User
    {
        [Key]
        public int UserID{get;set;}
        public string UserFirstName{get;set;}
        public string UserLastName{get;set;}
        public string UserName{get;set;}
        public string Gender{get;set;}
        //public  DateTime DateofBirth{get;set;}
        public string Country{get;set;}

    }
}