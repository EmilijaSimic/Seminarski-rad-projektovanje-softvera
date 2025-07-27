using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class Pozicija : OpstiDomenskiObjekat
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public string VratiNaziveKolona()
        {
            return "naziv";
        }

        public string VratiNazivTabele()
        {
            return "Pozicija";
        }

        public string VratiVrednostiKolona()
        {
            return $"'{Naziv}'";
        }

        public string VratiVrednostiZaPromenu()
        {
            return $"naziv = '{Naziv}'";
        }
    }
}
