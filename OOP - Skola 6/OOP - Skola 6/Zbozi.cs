using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Skola_6
{
    class Zbozi
    {
        string nazev;
        int cena;
        DateTime datumVyroby;
        DateTime minTrvandlivost;

        public Zbozi(string nazev, int cena, DateTime datumVyroby, DateTime minTrvandlivost)
        {
            this.nazev = nazev;
            this.cena = cena;
            this.datumVyroby = datumVyroby;
            this.minTrvandlivost = minTrvandlivost;
        }

        public bool SplnujeMinTrvandlivost()
        {
            return minTrvandlivost >= DateTime.Now ? true : false;
        }

        public int CenaSDPH()
        {
            return cena + (int)(cena * 0.21);
        }
    }
}
