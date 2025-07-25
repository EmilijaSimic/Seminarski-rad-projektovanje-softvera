using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    internal class PozicijaZaposlenog
    {
        public Zaposleni Zaposleni { get; set; }
        public Pozicija Pozicija { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
    }
}
