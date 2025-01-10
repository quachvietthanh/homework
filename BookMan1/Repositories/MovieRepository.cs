using BookMan1.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookMan1.Repositories
{
    public class MovieRepository
    {
        private List<Movie> _movies = new List<Movie>();

        public List<Movie> GetAllMovies()
        {
            return _movies;
        }

        public Movie GetMovieById(int id)
        {
            return _movies.FirstOrDefault(m => m.Id == id);
        }

        public void AddMovie(Movie movie)
        {
            _movies.Add(movie);
        }

        public void DeleteMovie(int id)
        {
            var movie = GetMovieById(id);
            if (movie != null)
            {
                _movies.Remove(movie);
            }
        }
    }
}