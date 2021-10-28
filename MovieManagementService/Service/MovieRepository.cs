using System.Collections.Generic;
using MovieManagementService.Models;
using System.Threading.Tasks;
using MovieManagementService.Data;
using System.Linq;


namespace MovieManagementService.Service
{
    public class MovieRepository : IMovieRepository
    {
        MovieDbContext _movieDbContext;
        public MovieRepository(MovieDbContext movieDbContext)
        {
            _movieDbContext=movieDbContext;
        }
        int IMovieRepository.AddMovie(Movie movie)
        {
            if(_movieDbContext!=null)
            {
             _movieDbContext.Add(movie);
             _movieDbContext.SaveChanges();
            return(movie.MovieId);
            }
            return 0;
        }

        int IMovieRepository.DeleteMovie(int id)
        {
            int res=0;
            var user=_movieDbContext.movies.FirstOrDefault(ctr=>ctr.MovieId==id);
                _movieDbContext.movies.Remove(user);
                res=_movieDbContext.SaveChanges();
            return res;  
        }

        IEnumerable<Movie> IMovieRepository.GetAllMovie()
        {
            var user=_movieDbContext.movies.ToList();
             return user;
        }

        Movie IMovieRepository.SearchMovie(int id)
        {
            var user=_movieDbContext.movies.FirstOrDefault(ctr=>ctr.MovieId==id);
            return user;
        }

        void IMovieRepository.UpdateMovie( Movie movie)
        {
             var contactToUpdate=_movieDbContext.movies.Where(ctr=>ctr.MovieId==movie.MovieId).SingleOrDefault();
             if(contactToUpdate!=null)
             {
                 contactToUpdate.MovieName=movie.MovieName;
                 contactToUpdate.Age=movie.Age;
             }
              
        }
    }
}