using Aufgabe_14.Framework;
using Aufgabe_14.Models;
using System.Collections.ObjectModel;

namespace Aufgabe_14.ViewModel
{
	public class MoviesViewModel : ViewModelBase, IMoviesViewModel
	{
		private ObservableCollection<Movie> _movies = new ObservableCollection<Movie>();
		public ObservableCollection<Movie> Movies { get => _movies; set => Set(ref _movies, value); }

		private Movie _selectedMovie;

		public Movie SelectedMovie
		{
			get => _selectedMovie;
			set => Set(ref _selectedMovie, value);
		}
	}
}
