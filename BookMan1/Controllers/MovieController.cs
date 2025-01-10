using BookMan1.Models;
using BookMan1.Repositories;
using BookMan1.Views;

namespace BookMan1.Controllers
{
    public class MovieController
    {
        private MovieRepository _repository = new MovieRepository();
        private MovieView _view = new MovieView();

        public void DisplayAllMovies()
        {
            var movies = _repository.GetAllMovies();
            _view.DisplayMovies(movies);
        }

        public void AddMovie()
        {
            var movie = _view.GetMovieInput();
            _repository.AddMovie(movie);
            _view.ShowMessage("Movie added successfully!");
        }

        public void DeleteMovie()
        {
            int id = _view.GetMovieIdInput();
            _repository.DeleteMovie(id);
            _view.ShowMessage("Movie deleted successfully!");
        }
    }
}
