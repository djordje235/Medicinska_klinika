using FluentNHibernate.Mapping;
using MedicinskaKlinika.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinskaKlinika.Mapiranja
{
    internal class BrTelefonaPacijentaMaper : ClassMap<BrTelefonaPacijenta>
    {
        public BrTelefonaPacijentaMaper() {

            Table("BR_TELEFONA_PACIJENTA");

            Id(x => x.Id).Column("ID").GeneratedBy.Sequence("BR_TELEFONA_PACIJENTA_ID_SEQ");

            Map(x => x.BrojTelefona).Column("BR_TELEFONA");

            References(x => x.Pacijent).Column("ID_KARTONA").LazyLoad();

        }
    }
}
