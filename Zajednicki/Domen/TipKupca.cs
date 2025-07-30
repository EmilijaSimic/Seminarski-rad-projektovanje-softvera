using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class TipKupca : OpstiDomenskiObjekat
    {
        public int Id {  get; set; }
        public string Naziv { get; set; }
        public double Popust { get; set; }

        public TipKupca() { }
        public TipKupca(int id, string naziv, double popust)
        {
            Id = id;
            Naziv = naziv;
            Popust = popust;
        }
        public string Join()
        {
            throw new NotImplementedException();
        }

        public OpstiDomenskiObjekat ProcitajRed(SqlDataReader ulaz)
        {
            TipKupca t = new TipKupca();
            t.Id = (int)ulaz["id"];
            t.Naziv = ulaz["naziv"].ToString();
            t.Popust = (double)ulaz["popust"];

            return t;
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
            return "naziv, popust";
        }

        public string VratiNazivTabele()
        {
            return "TipKupca";
        }

        public string VratiVrednostiKolona()
        {
            return $"'{Naziv}', {Popust.ToString(System.Globalization.CultureInfo.InvariantCulture)}";
        }

        public string VratiVrednostiZaPromenu()
        {
            return $"naziv = '{Naziv}', popust = {Popust.ToString(System.Globalization.CultureInfo.InvariantCulture)}";
        }

    }
}
