using FluentNHibernate.Mapping;
using MedicinskaKlinika.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinskaKlinika.Mapiranja
{
    internal class EmailPacijentaMaper : ClassMap<EmailPacijenta>
    {
        public EmailPacijentaMaper() {

            Table("EMAIL_PACIJENTA");

            Id(x => x.Id).Column("ID").GeneratedBy.Sequence("EMAIL_PACIJENTA_ID_SEQ");

            Map(x => x.Email).Column("EMAIL");

            References(x => x.Pacijent).Column("ID_KARTONA").LazyLoad();

        }
    }
}
