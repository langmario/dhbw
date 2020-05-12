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
    public interface IMovieAddViewModel : IViewModelBase
    {
        IEnumerable<Genre> Genres { get; set; }

        Movie Movie { get; set; }

        string Title { get; set; }
        Genre SelectedGenre { get; set; }

        ICommand OKCommand { get; set; }
        ICommand CancelCommand { get; set; }
    }
}
