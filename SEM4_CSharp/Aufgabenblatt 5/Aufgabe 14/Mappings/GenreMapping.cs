using Aufgabe_14.Models;
using FluentNHibernate.Mapping;

namespace Aufgabe_14.Mappings
{
    internal class GenreMapping : ClassMap<Genre>
    {
        public GenreMapping()
        {
            Table("Genres");
            Id(x => x.Id).GeneratedBy.Native();
            Map(x => x.Name).Not.Nullable();
            HasMany(x => x.Movies)
                .KeyColumn("GenreId")
                .Inverse()
                .Cascade.Delete();
        }
    }
}
