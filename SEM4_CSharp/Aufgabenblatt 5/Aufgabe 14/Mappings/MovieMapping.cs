using Aufgabe_14.Models;
using FluentNHibernate.Mapping;

namespace Aufgabe_14.Mappings
{
    internal class MovieMapping : ClassMap<Movie>
    {
        public MovieMapping()
        {
            Table("Movies");
            Id(x => x.Id).GeneratedBy.Native();
            Map(x => x.Title).Not.Nullable();
            References(x => x.Genre).Column("GenreId").Not.Nullable().Cascade.Delete();
        }
    }
}
