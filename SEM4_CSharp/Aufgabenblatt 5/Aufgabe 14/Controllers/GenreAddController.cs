using Aufgabe_14.Framework;
using Aufgabe_14.Models;
using Aufgabe_14.Repositories;
using Aufgabe_14.ViewModel;
using Aufgabe_14.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_14.Controllers
{
    public class GenreAddController : IGenreAddController
    {
        private readonly IRepository<Genre> _genreRepository;
        private readonly IGenreAddViewModel _vm;

        public GenreAddController(
            IRepository<Genre> genreRepository,
            IGenreAddViewModel genreAddViewModel
        )
        {
            _genreRepository = genreRepository;
            _vm = genreAddViewModel;

        }


        public Genre AddGenre()
        {
            var window = new GenreAddWindow();

            _vm.OKCommand = new RelayCommand(o => window.DialogResult = true);
            _vm.CancelCommand = new RelayCommand(o => window.DialogResult = false);

            _vm.Genre = new Genre();

            window.DataContext = _vm;

            var result = window.ShowDialog();
            if (result.HasValue && result.Value)
            {
                _genreRepository.Save(_vm.Genre);
                return _vm.Genre;
            }
            else
            {
                return null;
            }
        }
    }
}
