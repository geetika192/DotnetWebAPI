using System.ComponentModel.DataAnnotations;
namespace MovieManagementService.Models
{
    public class Movie
    {
        public int MovieId{get;set;}
        [Required]
        public string MovieName{get;set;}
        [Required]
        public int Age{get;set;}
    }
}