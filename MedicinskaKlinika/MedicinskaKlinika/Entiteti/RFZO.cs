using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinskaKlinika.Entiteti
{
    public class RFZO
    {
        public virtual int IdOsiguranja { get; set; }

        public virtual Pacijent Pacijent { get; set; }

        public virtual IList<Placanje> Placanja { get; set; }

        public RFZO()
        {
            Placanja = new List<Placanje>();
        }
    }
}
