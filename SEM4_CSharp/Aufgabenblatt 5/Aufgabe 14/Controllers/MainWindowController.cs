using Aufgabe_14.Framework;
using Aufgabe_14.Models;
using Aufgabe_14.Repositories;
using Aufgabe_14.ViewModel;
using Aufgabe_14.Views;
using NHibernate.Util;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace Aufgabe_14.Controllers
{
    public class MainWindowController
    {
        private readonly IRepository<Movie> _movieRepository;
        private readonly IRepository<Genre> _genreRepository;

        private readonly MainWindow _window;
        private readonly IMainWindowViewModel _vm;
        private readonly IMoviesViewModel _movies;
        private readonly IGenresViewModel _genres;
        private readonly IMovieAddController _movieAddController;
        private readonly IGenreAddController _genreAddController;

        public MainWindowController(
            IRepository<Movie> movieRepository,
            IRepository<Genre> genreRepository,
            IMovieAddController movieAddController,
            IGenreAddController genreAddController,
            IMainWindowViewModel mainWindowViewModel,
            IMoviesViewModel moviesViewModel,
            IGenresViewModel genresViewModel
        )
        {
            _window = new MainWindow();
            _vm = mainWindowViewModel;
            _movies = moviesViewModel;
            _genres = genresViewModel;
            _movieRepository = movieRepository;
            _genreRepository = genreRepository;

            _movieAddController = movieAddController;
            _genreAddController = genreAddController;

            _movies.Movies = new ObservableCollection<Movie>(_movieRepository.GetAll());
            _genres.Genres = new ObservableCollection<Genre>(_genreRepository.GetAll());

            _vm.ActiveViewModel = _movies;
            _vm.ChangeViewCommand = new RelayCommand(ChangeWindow);
            _vm.AddCommand = new RelayCommand(AddItem);
            _vm.DeleteCommand = new RelayCommand(DeleteItem, CanDeleteItem);

            _window.DataContext = _vm;
            _window.Show();
        }

        private void ChangeWindow(object obj)
        {
            if (obj is string viewName)
            {
                switch (viewName)
                {
                    case "movies":
                    {
                        _movies.Movies = new ObservableCollection<Movie>(_movieRepository.GetAll());
                        _vm.ActiveViewModel = _movies;
                        break;
                    }
                    case "genres":
                    {
                        _genres.Genres = new ObservableCollection<Genre>(_genreRepository.GetAll());
                        _vm.ActiveViewModel = _genres;
                        break;
                    }
                }
            }
        }

        private bool CanDeleteItem(object obj)
        {
            switch (_vm.ActiveViewModel)
            {
                case IMoviesViewModel vm:
                    return vm.SelectedMovie != null;
                case IGenresViewModel vm:
                    return vm.SelectedGenre != null;
                default:
                    return false;
            }
        }

        private void DeleteItem(object obj)
        {
            switch (_vm.ActiveViewModel)
            {
                case IMoviesViewModel vm:
                {
                    _movieRepository.Delete(vm.SelectedMovie);
                    _movies.Movies.Remove(vm.SelectedMovie);
                    break;
                }
                case IGenresViewModel vm:
                {
                    var toDelete = vm.SelectedGenre;
                    if (_movieRepository.GetAll().Any(m => m.Genre.Id == toDelete.Id))
                    {
                        var result = MessageBox.Show($"Wenn Sie das Genre '{toDelete.Name}' löschen werden auch alle zugehörigen Filme gelöscht!", "Warnung", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                        if (result == MessageBoxResult.OK)
                        {
                            _genreRepository.Delete(vm.SelectedGenre);
                            _genres.Genres.Remove(vm.SelectedGenre);
                        }
                    }
                    break;
                }
            }
        }

        private void AddItem(object obj)
        {
            switch (_vm.ActiveViewModel)
            {
                case IMoviesViewModel vm:
                {
                    var result = _movieAddController.AddMovie();
                    if (result != null)
                        vm.Movies.Add(result);
                    break;
                }
                case IGenresViewModel vm:
                {
                    var result = _genreAddController.AddGenre();
                    if (result != null)
                        vm.Genres.Add(result);
                    break;
                }
            }
        }
    }
}
