using Microsoft.Data.SqlClient;
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

        public Pozicija() { }
        public Pozicija(int id, string naziv)
        {
            Id = id;
            Naziv = naziv;
        }

        public string Join()
        {
            throw new NotImplementedException();
        }

        public OpstiDomenskiObjekat ProcitajRed(SqlDataReader ulaz)
        {
            Pozicija p = new Pozicija();
            p.Id = (int)ulaz["id"];
            p.Naziv = ulaz["naziv"].ToString();

            return p;
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

        public override string ToString()
        {
            return Naziv;
        }

    }
}
