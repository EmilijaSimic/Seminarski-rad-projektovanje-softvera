using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    internal class Potvrda
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public double Cena { get; set; }
        public double Popust { get; set; }
        public double IznosUkupno { get; set; }
        public Zaposleni Zaposleni { get; set; }
        public Kupac Kupac { get; set; }

    }
}
