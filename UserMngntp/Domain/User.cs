namespace UserMngntp.Domain
{
    public class User: BaseEntity
    {
        public string UserName{get;set;}
        public string Email{get;set;}
        public string Password{get;set;}

        public UserProfile userProfile{get;set;}  //navigation

    }
}