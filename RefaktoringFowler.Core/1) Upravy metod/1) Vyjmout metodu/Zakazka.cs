using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefaktoringFowler.Core.VyjmoutMetodu
{
    public class Zakazka
    {
        public double Castka { get; private set; }

        public Zakazka(double castka)
        {
            Castka = castka;
        }
    }
}
