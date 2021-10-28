using System;

namespace UserManagemment2.Domain
{
    public class UserDTO  //Combo of user and userprofile (it can also be in controller)
    {
        public int Id { get; set; }
        public string First { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string IPAddress { get; set; }

    }
}