using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Skola_6
{
    internal class Produkt :Zbozi
    {
        private bool lzeZlevnit;
        public Produkt(string nazev, int cena, DateTime datumVyroby, DateTime minTrvandlivost, bool lzeZlevnit) : base(nazev, cena, datumVyroby, minTrvandlivost)
        {
            this.lzeZlevnit = lzeZlevnit;
        }

        public override int CenaSDPH()
        {
            return SplnujeMinTrvandlivost() ? base.CenaSDPH():(int)(base.CenaSDPH()*(double)0.6);
        }
    }
}
