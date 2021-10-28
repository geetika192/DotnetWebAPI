using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssignmentCRUD.Models
{
    public class EmployeesMap
    {
        public EmployeesMap(EntityTypeBuilder<Employees> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x=>x.EmpId);
            entityTypeBuilder.Property(x=>x.EmpName).IsRequired();
            entityTypeBuilder.Property(x=> x.EmpSalary).HasMaxLength(7);
        }
    }
}