using Aufgabe_14.Framework;
using Aufgabe_14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Aufgabe_14.ViewModel
{
    class MovieAddViewModel : ViewModelBase, IMovieAddViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public Movie Movie { get; set; } = new Movie();

        public string Title
        {
            get => Movie.Title;
            set
            {
                if (Movie.Title != value)
                {
                    Movie.Title = value;
                    RaisePropertyChanged();
                }
            }
        }
        public Genre SelectedGenre
        {
            get => Movie.Genre;
            set
            {
                if (Movie.Genre != value)
                {
                    Movie.Genre = value;
                    RaisePropertyChanged();
                }
            }
        }


        public ICommand OKCommand { get; set; }
        public ICommand CancelCommand { get; set; }
    }
}
