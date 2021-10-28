namespace UserMngntp.Domain
{
    public class UserProfile:BaseEntity
    {
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public User user{get;set;} //Navigation
        
    }
}