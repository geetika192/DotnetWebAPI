using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace UserMngntp.Domain
{
    public class UserProfileMap
    {
        public UserProfileMap(EntityTypeBuilder<UserProfile> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(ctr => ctr.Id);
            entityTypeBuilder.Property(ctr => ctr.FirstName);
            entityTypeBuilder.Property(ctr => ctr.LastName);
        }
    }
}