using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_1._0
{
    public class ZapiszGracza
    {
        public string Imie;
        public int Atak;
        public int Pomoc;
        public int Obrona;

        public ZapiszGracza() { }

        public ZapiszGracza(string imie, int atak, int pomoc, int obrona)
        {
            this.Imie = imie;
            this.Atak = atak;
            this.Pomoc = pomoc;
            this.Obrona = obrona;
        }

        public override string ToString()
        {
            return Imie + " => Atak: " + Atak + " || Pomoc: " + Pomoc + " || Obrona: " + Obrona;
        }
    }
}
