
using System.ComponentModel.DataAnnotations;

namespace EFCorePracticeLast.Model
{
    public class Student
    {
        [Key] // data annotation
        public int Sid{get; set;}
        public string Sname{get; set;}
    }
}