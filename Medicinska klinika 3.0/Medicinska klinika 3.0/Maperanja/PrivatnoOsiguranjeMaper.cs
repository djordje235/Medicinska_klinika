﻿using FluentNHibernate.Mapping;
using MedicinskaKlinika.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MedicinskaKlinika.Mapiranja
{
    internal class PrivatnoOsiguranjeMaper : ClassMap<PrivatnoOsiguranje>
    {
        public PrivatnoOsiguranjeMaper()
        {
            Table("PRIVATNO_OSIGURANJE");
            Id(x => x.IdOsiguranja).Column("ID_OSIGURANJA").GeneratedBy.Sequence("PRIVATNO_OSIGURANJE_ID_SEQ");

            Map(x => x.BrPolise).Column("BR_POLISE");
            Map(x => x.OsiguravajucaKuca).Column("OSIGURAVAJUCA_KUCA");

            HasMany(x => x.Placanja).KeyColumn("ID_PRIV").LazyLoad().Cascade.All().Inverse();
            References(x => x.Pacijent, "ID_KARTONA").Unique();
        }
    }
}
