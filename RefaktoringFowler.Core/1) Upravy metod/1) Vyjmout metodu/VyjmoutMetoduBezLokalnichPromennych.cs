using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefaktoringFowler.Core.VyjmoutMetodu
{
    public class VyjmoutMetoduBezLokalnichPromennych
    {
        private string _jmeno ;
        private List<Zakazka> _zakazky;
        
        public VyjmoutMetoduBezLokalnichPromennych()
        {
            _jmeno = "Karel Vomacka";
            _zakazky = new List<Zakazka>
            {
                new Zakazka(15.25),
                new Zakazka(18.30),
                new Zakazka(5.50)
            };
        }
        
        public void TiskUctu()
        {
            TiskZahlavi();
            double zaplatit = GetZaplatit();
            TiskPolozky(zaplatit);
        }

        private void TiskZahlavi()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("***** Zakaznik ma platit *****");
            Console.WriteLine("******************************");
        }

        private void TiskPolozky(double zaplatit)
        {
            Console.WriteLine("Jmeno: " + _jmeno);
            Console.WriteLine("Castka: " + zaplatit);
        }

        private double GetZaplatit()
        {
            double zaplatit = 0.0;
            foreach (var zakazka in _zakazky)
            {
                zaplatit += zakazka.Castka;
            }
            return zaplatit;
        }
    }
}
