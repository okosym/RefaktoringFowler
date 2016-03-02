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
            double zaplatit = 0.0;

            // tisk zahlavi
            Console.WriteLine("******************************");
            Console.WriteLine("***** Zakaznik ma platit *****");
            Console.WriteLine("******************************");

            // vypocet castky k zaplaceni
            foreach (var zakazka in _zakazky)
            {
                zaplatit += zakazka.Castka;
            }

            // tisk polozky
            Console.WriteLine("Jmeno: " + _jmeno);
            Console.WriteLine("Castka: " + zaplatit);
        }
    }
}
