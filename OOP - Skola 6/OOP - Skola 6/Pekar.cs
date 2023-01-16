using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Skola_6
{
    class Pekar : Zamestnanec
    {
        short pocetHodinVNoci = 0;

        public Pekar(string jmeno, string prijmeni, DateTime datumNarozeni, short hodinovaMzda, short pocetHodinVNoci) : base(jmeno,prijmeni,datumNarozeni,hodinovaMzda)
        {
            this.pocetHodinVNoci = pocetHodinVNoci;
        }

        public void OdpracujHodiny(short hodinyVeDne, short hodinyVNoci)
        {
            base.OdpracujHodiny(hodinyVeDne);
            pocetHodinVNoci += hodinyVNoci;
        }

        public new int Mzda()
        {
            return base.Mzda() + (pocetHodinVNoci * hodinovaMzda * 2);
        }

        public new string Vypis()
        {
            return base.Vypis() + "\nHodiny v noci: " + pocetHodinVNoci;
        }
    }
}
