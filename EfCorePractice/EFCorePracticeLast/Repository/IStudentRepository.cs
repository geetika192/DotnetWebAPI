using System;
using  EFCorePracticeLast.Model;
using System.Collections.Generic;
namespace EFCorePracticeLast.Repository
{
    public interface IStudentRepository
    {
        void AddDetails(Student student);
        void UpdateDetails(Student student);
        void DeleteDetails(int id);
        Student GetSingleDetail(int id);
        List<Student> GetAllRecord();

    }
}