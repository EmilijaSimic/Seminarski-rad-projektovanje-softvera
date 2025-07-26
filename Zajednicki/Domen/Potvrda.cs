using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Komunikacija;

namespace Zajednicki.Domen
{
    public class Potvrda : OpstiDomenskiObjekat
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
