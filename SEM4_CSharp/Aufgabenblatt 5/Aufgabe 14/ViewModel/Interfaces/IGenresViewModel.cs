using Aufgabe_14.Framework;
using Aufgabe_14.Models;
using System.Collections.ObjectModel;

namespace Aufgabe_14.ViewModel
{
    public interface IGenresViewModel : IViewModelBase
    {
        ObservableCollection<Genre> Genres { get; set; }
        Genre SelectedGenre { get; set; }
    }
}