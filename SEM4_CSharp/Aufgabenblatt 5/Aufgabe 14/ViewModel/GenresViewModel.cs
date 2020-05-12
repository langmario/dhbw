using Aufgabe_14.Framework;
using Aufgabe_14.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_14.ViewModel
{
	public class GenresViewModel : ViewModelBase, IGenresViewModel
	{
		private ObservableCollection<Genre> _genres = new ObservableCollection<Genre>();
		public ObservableCollection<Genre> Genres { get => _genres; set => Set(ref _genres, value); }

		private Genre _selectedGenre;

		public Genre SelectedGenre
		{
			get => _selectedGenre;
			set => Set(ref _selectedGenre, value);
		}
	}
}
