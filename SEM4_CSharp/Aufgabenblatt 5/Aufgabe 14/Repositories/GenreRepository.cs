using Aufgabe_14.Framework;
using Aufgabe_14.Models;

namespace Aufgabe_14.Repositories
{
    public class GenreRepository : BaseRepository<Genre>
    {
        public GenreRepository(INHibernateHelper helper) : base(helper)
        {

        }
        // Spezialisierte Abfragen
    }
}
