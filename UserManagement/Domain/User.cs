namespace userManagement.Domain
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public UserProfile userProfile { get; set; } //nevigation


    }
}