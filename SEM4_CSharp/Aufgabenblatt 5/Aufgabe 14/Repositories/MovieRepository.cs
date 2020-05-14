using Aufgabe_14.Framework;
using Aufgabe_14.Models;

namespace Aufgabe_14.Repositories
{
    public class MovieRepository : BaseRepository<Movie>
    {
        public MovieRepository(INHibernateHelper helper) : base(helper)
        {

        }
        // Spezialisierte Abfragen
    }
}
