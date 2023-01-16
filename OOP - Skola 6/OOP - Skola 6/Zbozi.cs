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
            return (minTrvandlivost - DateTime.Now).TotalDays >= 0;
        }

        public virtual int CenaSDPH()
        {
            return (int)(cena * (double)1.21);
        }

        public override string ToString()
        {
            return String.Format("Náazev: {0}\nCena: {1}Kč\nDatum výroby: {2}\nMinimální trvandlivost: {3}\nPřekročilo min. trvandlivost: {4}\nCena s DPH: {5}Kč", 
                nazev,cena,datumVyroby.ToString("d"), minTrvandlivost.ToString("d"), SplnujeMinTrvandlivost() ? "Ne":"Ano", CenaSDPH());
        }
    }
}
