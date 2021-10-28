using System.ComponentModel.DataAnnotations;
namespace CreatingMembership.Models
{
    public class User
    {
      
        [Required]
        public string UserName{get;set;}
        public int Id{get;set;}
        [Required]
        public string Password{get;set;}
        [Required]
        public int Age{get;set;}
    }
}