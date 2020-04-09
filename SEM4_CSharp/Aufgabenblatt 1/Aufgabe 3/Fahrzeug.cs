using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3
{
    public class Fahrzeug
    {
        public string Kennzeichen { protected get; set; }

        public virtual string Drive()
        {
            return Kennzeichen;
        }
    }
}
