using Microsoft.Data.SqlClient;
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

        public PozicijaZaposlenog() { }
        public PozicijaZaposlenog(Zaposleni zaposleni, Pozicija pozicija, DateTime datumPocetka, DateTime datumKraja)
        {
            Zaposleni = zaposleni;
            Pozicija = pozicija;
            DatumPocetka = datumPocetka;
            DatumZavrsetka = datumKraja;
        }

        public string Join()
        {
            throw new NotImplementedException();
        }

        public OpstiDomenskiObjekat ProcitajRed(SqlDataReader ulaz)
        {
            PozicijaZaposlenog k = new PozicijaZaposlenog();
            k.Zaposleni = new Zaposleni();
            k.Pozicija = new Pozicija();
            k.Pozicija.Id = (int)ulaz[0];
            k.Zaposleni.Id = (int)ulaz[1];
            k.DatumPocetka = (DateTime)ulaz[2];
            k.DatumZavrsetka = (DateTime)ulaz[3];

            return k;
        }

        public string Uslov()
        {
            throw new NotImplementedException();
        }

        public string UslovZaPretragu(string filter)
        {
            return "idZaposleni = " + filter;
        }

        public string VratiNaziveKolona()
        {
            return "idZaposleni, idPozicija, datumPocetka, datumZavrsetka";
        }

        public string VratiNazivTabele()
        {
            return "PozicijaZaposlenog";
        }

        public string VratiVrednostiKolona()
        {
            return $"{Zaposleni.Id}, {Pozicija.Id}, '{DatumPocetka:yyyy-MM-dd HH:mm:ss}', '{DatumZavrsetka:yyyy-MM-dd HH:mm:ss}'";
        }

        public string VratiVrednostiZaPromenu()
        {
            return $"idZaposleni = {Zaposleni.Id}, idPozicija = {Pozicija.Id}, datumPocetka = '{DatumPocetka:yyyy-MM-dd HH:mm:ss}', datumZavrsetka = '{DatumZavrsetka:yyyy-MM-dd HH:mm:ss}'";
        }

        public override string ToString()
        {
            return Pozicija.Id.ToString();
        }
    }
}
