using Microsoft.EntityFrameworkCore;
using PatientRepository.Models;
namespace PatientRepository.DataAccess
{
    public class PatientDBContext : DbContext
    {
        public PatientDBContext(DbContextOptions dbContextOptions ): base(dbContextOptions)
        {
            
        }
        public DbSet<Patients> patients{get;set;}  //for Local Manipulation
    }
}