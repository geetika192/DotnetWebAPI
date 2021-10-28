using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CreatingMembership.Models
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityTypeBuilder)
        {
           
            entityTypeBuilder.Property(t => t.UserName).HasMaxLength(30).IsRequired();
            entityTypeBuilder.Property(t => t.Password).HasMaxLength(30).IsRequired();
            entityTypeBuilder.Property(t => t.Age).HasMaxLength(3).IsRequired();
        }
    }
}

