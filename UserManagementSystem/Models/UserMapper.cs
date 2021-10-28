using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace UserManagementSystem.Models
{
    //now we are implementing fluentapi for defining the structue or schema for user
    public class UserMapper
    {
        public UserMapper(EntityTypeBuilder<User> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.id);
            entityTypeBuilder.Property(t => t.name).IsRequired();
            entityTypeBuilder.Property(t => t.phone).IsRequired();
        }
    }
}