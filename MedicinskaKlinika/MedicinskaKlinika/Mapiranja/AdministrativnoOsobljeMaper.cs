using FluentNHibernate.Mapping;
using MedicinskaKlinika.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinskaKlinika.Mapiranja
{
    internal class AdministrativnoOsobljeMaper : SubclassMap<AdministrativnoOsoblje>
    {
        public AdministrativnoOsobljeMaper()
        {
            Table("ADMINISTRATIVNO_OSOBLJE");

            KeyColumn("JMBG");


        }
    }
}
