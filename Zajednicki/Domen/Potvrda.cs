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
        public List<StavkaPotvrde> Stavke { get; set; } = new List<StavkaPotvrde>();

        public string Join()
        {
            return "p JOIN Kupac k on (p.idKupac = k.id) JOIN Zaposleni z on (p.idZaposleni = z.id)";
        }

        public OpstiDomenskiObjekat ProcitajRed(SqlDataReader ulaz)
        {
            Potvrda p = new Potvrda();

            p.Id = (int)ulaz[0];
            p.Datum = (DateTime)ulaz[1];
            p.Cena = (double)ulaz[2];
            p.Popust = (double)ulaz[3];
            p.IznosUkupno = (double)ulaz[4];

            Zaposleni z = new Zaposleni();
            z.Id = (int)ulaz[15];
            z.Jmbg = ulaz[16].ToString();
            z.Ime = ulaz[17].ToString();
            z.Prezime = ulaz[18].ToString();
            z.KorisnickoIme = ulaz[19].ToString();
            z.Lozinka = ulaz[20].ToString();
            p.Zaposleni = z;

            Kupac k = new Kupac();
            k.Id = (int)ulaz[7];
            k.Ime = ulaz[8].ToString();
            k.Prezime = ulaz[9].ToString();
            k.Telefon = ulaz[10].ToString();
            k.BrojPlatneKartice = ulaz[11].ToString();
            k.Aktivan = (bool)ulaz[12];
            TipKupca tk = new TipKupca();
            tk.Id = (int)ulaz[13];
            k.TipKupca = tk;
            p.Kupac = k;

            return p;
        }

        public string Uslov()
        {
            return $"id = {Id}";
        }

        public string UslovZaPretragu(string filter)
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
