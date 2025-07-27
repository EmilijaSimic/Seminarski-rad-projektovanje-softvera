using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class StavkaPotvrde : OpstiDomenskiObjekat
    {
        public int Rb { get; set; }
        public Potvrda Potvrda { get; set; }
        public int Kolicina { get; set; }
        public double Cena { get; set; }
        public double Iznos {  get; set; }
        public Dogadjaj Dogadjaj { get; set; }

        public string VratiNaziveKolona()
        {
            return "idPotvrda, kolicina, cena, iznos, idDogadjaj";
        }

        public string VratiNazivTabele()
        {
            return "StavkaPotvrde";
        }

        public string VratiVrednostiKolona()
        {
            return $"{Potvrda.Id}, {Kolicina}, {Cena.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {Iznos.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {Dogadjaj.Id}";
        }

        public string VratiVrednostiZaPromenu()
        {
            return $"idPotvrda = {Potvrda.Id}, kolicina = {Kolicina}, cena = {Cena.ToString(System.Globalization.CultureInfo.InvariantCulture)}, iznos = {Iznos.ToString(System.Globalization.CultureInfo.InvariantCulture)}, idDogadjaj = {Dogadjaj.Id}";
        }
    }
}
