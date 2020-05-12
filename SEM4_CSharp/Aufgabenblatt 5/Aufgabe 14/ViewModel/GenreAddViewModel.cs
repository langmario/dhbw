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
    class GenreAddViewModel : ViewModelBase, IGenreAddViewModel
    {
        public Genre Genre { get; set; } = new Genre();
        public string Name
        {
            get => Genre.Name;
            set
            {
                Genre.Name = value;
                RaisePropertyChanged();
            }
        }


        public ICommand OKCommand { get; set; }
        public ICommand CancelCommand { get; set; }
    }
}
