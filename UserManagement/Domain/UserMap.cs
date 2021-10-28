using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace userManagement.Domain
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.EMail).IsRequired();
            entityTypeBuilder.Property(t => t.Password).IsRequired();
            entityTypeBuilder.HasOne(t =>t.userProfile).WithOne( t=>t.user).HasForeignKey<UserProfile>(t=>t.Id);  // one to one reletionship
        }
    }
}