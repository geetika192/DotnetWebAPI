using EFCorePracticeLast.Model;
using System;
using EFCorePracticeLast.Repository;

namespace EFCorePracticeLast
{    
    class Program
    {
        static void Main()
        {
           IStudentRepository istud = (IStudentRepository) new StudentRepository();
           Student student=new Student();
           
           istud.AddDetails(new Student{
               Sname="Deepti"   
           });

        }
    }
}
