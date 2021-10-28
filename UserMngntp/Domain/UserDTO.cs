using System;
namespace UserMngntp.Domain
{
    public class UserDTO
    {
        public int Id{get;set;}
        public DateTime AddedDate{get;set;}
        public DateTime ModifiedDate{get;set;}
        public string IPAddress{get;set;}
         public string UserName{get;set;}
        public string Email{get;set;}
        public string Password{get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}


    }
}