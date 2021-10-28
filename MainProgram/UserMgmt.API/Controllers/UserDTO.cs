using System;

namespace Domain
{
    public class UserDTO
    {
        public Int64 Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string IPAddress { get; set; } 
         public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual UserProfile UserProfile { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public virtual User User { get; set; } 
    }
}