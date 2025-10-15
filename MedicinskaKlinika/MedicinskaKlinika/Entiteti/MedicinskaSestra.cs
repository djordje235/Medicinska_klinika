using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinskaKlinika.Entiteti
{
    public class MedicinskaSestra : Zaposlen
    {
        public virtual String OblastRada { get; set; }

        public virtual String Sertifikat { get; set; }
    }
}
