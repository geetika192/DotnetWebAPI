using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace UserManagemment2.Domain
{
    public class UserProfileMap
    {
        public UserProfileMap(EntityTypeBuilder<UserProfile> entityTypeBuilder)
        {
           entityTypeBuilder.HasKey(t => t.Id);
           entityTypeBuilder.Property(t => t.FirstName).IsRequired();
           entityTypeBuilder.Property(t => t.LastName).IsRequired();
           entityTypeBuilder.Property(t => t.Address); 
        } 
    }
}
