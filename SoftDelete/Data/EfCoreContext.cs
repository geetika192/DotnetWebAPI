using Microsoft.EntityFrameworkCore;
using SoftDelete.Model;
using SoftDelete.Repository;
namespace SoftDelete.Data
{
    public class EfCoreContext : DbContext
    {
        public EfCoreContext(DbContextOptions<EfCoreContext> options) : base(options)
        {

        }

        //Other code left out to focus on Soft delete

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                //other automated configurations left out
                if (typeof(IIsDeleted).IsAssignableFrom(entityType.ClrType))
                {
                    entityType.AddSoftDeleteQueryFilter();
                }
            }
        }
    }
}