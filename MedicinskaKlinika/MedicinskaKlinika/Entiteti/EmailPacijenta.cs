﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinskaKlinika.Entiteti
{
    public class EmailPacijenta
    {
        public virtual int Id { get; set; }
        public virtual Pacijent Pacijent { get; set; }

        public virtual String Email { get; set; }
    }
}
