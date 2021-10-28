using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace UserManagemment2.Domain
{
    public class UserMap
    {
       public UserMap(EntityTypeBuilder<User> entityTypeBuilder)
       {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.UserName).IsRequired();
            entityTypeBuilder.Property(t => t.Password).IsRequired();
            entityTypeBuilder.Property(t => t.Email).IsRequired();
            entityTypeBuilder.HasOne(   t => t.userProfile).WithOne(t => t.user).HasForeignKey<UserProfile>( t=> t.Id );
       } 
    }
}