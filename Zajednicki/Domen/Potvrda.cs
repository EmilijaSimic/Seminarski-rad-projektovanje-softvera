using Microsoft.Data.SqlClient;
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

        public OpstiDomenskiObjekat ProcitajRed(SqlDataReader ulaz)
        {
            throw new NotImplementedException();
        }

        public string VratiNaziveKolona()
        {
            return "datum, cena, popust, iznosUkupno, idZaposleni, idKupac";
        }

        public string VratiNazivTabele()
        {
            return "Potvrda";
        }

        public string VratiVrednostiKolona()
        {
            return $"'{Datum:yyyy-MM-dd HH:mm:ss}', {Cena.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {Popust.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {IznosUkupno.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {Zaposleni.Id}, {Kupac.Id}";
        }

        public string VratiVrednostiZaPromenu()
        {
            return $"datum = '{Datum:yyyy-MM-dd HH:mm:ss}', cena = {Cena.ToString(System.Globalization.CultureInfo.InvariantCulture)}, popust = {Popust.ToString(System.Globalization.CultureInfo.InvariantCulture)}, iznosUkupno = {IznosUkupno.ToString(System.Globalization.CultureInfo.InvariantCulture)}, idZaposleni = {Zaposleni.Id}, idKupac = {Kupac.Id}";
        }
    }
}
