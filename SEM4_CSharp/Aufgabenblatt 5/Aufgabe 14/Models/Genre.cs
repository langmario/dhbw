using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Aufgabe_14.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Movie> Movies { get; set; } = new Collection<Movie>();
    }
}
