using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class Dogadjaj : OpstiDomenskiObjekat
    {
        public int Id { get; set; }
        public string Izvodjac { get; set; }
        public string Hala {  get; set; }
        public string Mesto {  get; set; }
        public DateTime Datum { get; set; }
        public double Cena { get; set; }

        public string VratiNaziveKolona()
        {
            return "izvodjac, hala, mesto, datum, cena";
        }

        public string VratiNazivTabele()
        {
            return "Dogadjaj";
        }

        public string VratiVrednostiKolona()
        {
            return $"'{Izvodjac}', '{Hala}', '{Mesto}', '{Datum:yyyy-MM-dd}', {Cena.ToString(System.Globalization.CultureInfo.InvariantCulture)}";
        }

        public string VratiVrednostiZaPromenu()
        {
            return $"izvodjac = '{Izvodjac}', hala = '{Hala}', mesto = '{Mesto}', datum = '{Datum:yyyy-MM-dd HH:mm:ss}', cena = {Cena.ToString(System.Globalization.CultureInfo.InvariantCulture)}";

        }
    }
}
