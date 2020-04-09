using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3
{
    public class LKW : Fahrzeug
    {
        public new string Drive()
        {
            return $"LKW {Kennzeichen}";
        }
    }
}
