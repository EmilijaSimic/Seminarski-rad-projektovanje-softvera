using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class PozicijaZaposlenog : OpstiDomenskiObjekat
    {
        public Zaposleni Zaposleni { get; set; }
        public Pozicija Pozicija { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
    }
}
