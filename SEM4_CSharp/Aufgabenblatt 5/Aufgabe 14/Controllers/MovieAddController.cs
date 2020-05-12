using Aufgabe_14.Framework;
using Aufgabe_14.Models;
using Aufgabe_14.Repositories;
using Aufgabe_14.ViewModel;
using Aufgabe_14.Views;

namespace Aufgabe_14.Controllers
{
    public class MovieAddController : IMovieAddController
    {
        private readonly IRepository<Movie> _movieRepository;
        private readonly IRepository<Genre> _genreRepository;
        private readonly IMovieAddViewModel _vm;

        public MovieAddController(
            IMovieAddViewModel addViewModel,
            IRepository<Movie> movieRepository,
            IRepository<Genre> genreRepository
        )
        {
            _movieRepository = movieRepository;
            _genreRepository = genreRepository;
            _vm = addViewModel;


        }


        public Movie AddMovie()
        {
            var window = new MovieAddWindow();

            _vm.OKCommand = new RelayCommand(o => window.DialogResult = true, o => _vm.SelectedGenre != null);
            _vm.CancelCommand = new RelayCommand(o => window.DialogResult = false);
            _vm.Movie = new Movie();

            window.DataContext = _vm;
            _vm.Genres = _genreRepository.GetAll();

            var result = window.ShowDialog();
            if (result.HasValue && result.Value)
            {
                _movieRepository.Save(_vm.Movie);
                return _vm.Movie;
            }
            else
            {
                return null;
            }
        }
    }
}
