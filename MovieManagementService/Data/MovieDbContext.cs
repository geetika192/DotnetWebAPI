using Microsoft.EntityFrameworkCore;
using MovieManagementService.Models;
namespace MovieManagementService.Data
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> movies { get; set; }

        public MovieDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Linking Between User(Model) and UserMap(Mapper)
            new MovieMap(modelBuilder.Entity<Movie>());
            modelBuilder.Entity<Movie>().HasData(
            new Movie { MovieId = 1, MovieName = "blue", Age = 123 },
            new Movie { MovieId = 2, MovieName = "DDLJ", Age = 14 });
        //    new Movie { MovieId = 3, MovieName = "IronMan", Age = 15 },
        //   new Movie { MovieId = 4, MovieName = "thor", Age = 17 },
        //    new Movie { MovieId = 5, MovieName = "Aunt man", Age = 18 });

        }
    }
}
