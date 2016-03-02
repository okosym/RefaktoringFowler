using System;

namespace RefaktoringFowler.Core.VyjmoutMetodu
{
    public class VyjmoutMetodu
    {
        private string _jmeno;

        public void TiskUctu(double castka)
        {
            TiskZahlavi();

            //tisk polozky
            Console.WriteLine("Jmeno: " + _jmeno);
            Console.Write("Castka: " + castka);
        }

        private void TiskZahlavi()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("***** Zakaznik ma platit *****");
            Console.WriteLine("******************************");
        }
    }
}
