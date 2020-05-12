using Aufgabe_14.Framework;
using Aufgabe_14.Models;
using System.Collections.ObjectModel;

namespace Aufgabe_14.ViewModel
{
    public interface IMoviesViewModel : IViewModelBase
    {
        ObservableCollection<Movie> Movies { get; set; }
        Movie SelectedMovie { get; set; }
    }
}