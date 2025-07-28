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

        public string Join()
        {
            throw new NotImplementedException();
        }

        public OpstiDomenskiObjekat ProcitajRed(SqlDataReader ulaz)
        {
            throw new NotImplementedException();
        }

        public string Uslov()
        {
            throw new NotImplementedException();
        }

        public string UslovZaPretragu(string filter)
        {
            throw new NotImplementedException();
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

    }
}
