using EfP.Domain;
using Microsoft.EntityFrameworkCore;

namespace EfP.Context
{
    public class UDbContext : DbContext
    {
        public DbSet<User> users { get; set; }
        // public UDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        // {

        // }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //we use this to configure the context

            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;User ID=postgres;Password=root;Database=Day51;Pooling=true;");
        }
    }
}