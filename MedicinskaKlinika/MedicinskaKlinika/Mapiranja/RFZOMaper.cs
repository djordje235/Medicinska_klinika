using FluentNHibernate.Mapping;
using MedicinskaKlinika.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinskaKlinika.Mapiranja
{
    internal class RFZOMaper : ClassMap<RFZO>
    {
        public RFZOMaper() {
            Table("RFZO");

            Id(x => x.IdOsiguranja).Column("ID_OSIGURANJA").GeneratedBy.Sequence("RFZO_ID_SEQ");

            HasMany(x => x.Placanja).KeyColumn("ID_OSIGURANJA").LazyLoad().Cascade.All().Inverse();
            References(x => x.Pacijent, "ID_KARTONA").Unique();
            
        }

    }
}
