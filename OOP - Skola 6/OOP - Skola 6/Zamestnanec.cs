using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Skola_6
{
    class Zamestnanec
    {
        protected string jmeno;
        protected string prijmeni;
        protected DateTime datumNarozeni;
        protected short hodinovaMzda;
        public short HodinovaMzda { get => hodinovaMzda; }
        protected short odpracHodiny;

        public Zamestnanec(string jmeno, string prijmeni, DateTime datumNarozeni, short hodinovaMzda)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNarozeni = datumNarozeni;
            this.hodinovaMzda = hodinovaMzda;
            odpracHodiny = 0;
        }

        protected virtual int Vek()
        {
            return (int)((DateTime.Now - datumNarozeni).TotalDays/365.25);
        }

        protected virtual void OdpracujHodiny(short hodiny)
        {
            odpracHodiny += hodiny;
        }

        protected virtual int Mzda()
        {
            return hodinovaMzda * odpracHodiny;
        }

        protected virtual string Vypis()
        {
            return String.Format("Jmeno: {0}\nPřijmení: {1}\nDatum nástupu: {2}\nHodinová mzda: {3}\nOdpracované hodiny: {4}\nZatím neproplacená mzda: {5}",
                jmeno, prijmeni, datumNarozeni.ToString("d"), HodinovaMzda, odpracHodiny, Mzda());
        }
    }
}
