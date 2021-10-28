using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MovieManagementService.Models
{
    public class MovieMap
    {
        public MovieMap(EntityTypeBuilder<Movie> movies)
        {
           
            movies.HasKey(t => t.MovieId);
            movies.Property(t => t.MovieName).HasMaxLength(30).IsRequired();
            movies.Property(t => t.Age).HasMaxLength(3).IsRequired();
        }
    }
}