using System.Collections.Generic;
using EFCorePracticeLast.Model;
using System.Linq;
namespace EFCorePracticeLast.Repository
{
    public class StudentRepository : IStudentRepository
    {
        StudentDbContext studentDbContext=new StudentDbContext();
       
         void IStudentRepository.AddDetails(Student student)
        {
            studentDbContext.std.Add(student);
            studentDbContext.SaveChanges();
        }

        void IStudentRepository.DeleteDetails(int id)
        {
            var delete = studentDbContext.std.FirstOrDefault(t => t.Sid == id);
            studentDbContext.std.Remove(delete);
            studentDbContext.SaveChanges();
        }

        List<Student> IStudentRepository.GetAllRecord()
        {
           return studentDbContext.std.ToList();
        }

        Student IStudentRepository.GetSingleDetail(int id)
        {
            return studentDbContext.std.FirstOrDefault(t => t.Sid == id);
        }

        void IStudentRepository.UpdateDetails(Student student)
        {
            studentDbContext.std.Update(student);
            studentDbContext.SaveChanges();
        }
    }
}