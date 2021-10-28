using MovieManagementService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MovieManagementService.Service
{
    public interface IMovieRepository
    {
        int AddMovie(Movie movie);
        void  UpdateMovie(Movie movie);
        int DeleteMovie(int id);
        Movie SearchMovie(int id);
        IEnumerable<Movie> GetAllMovie();
    }
}