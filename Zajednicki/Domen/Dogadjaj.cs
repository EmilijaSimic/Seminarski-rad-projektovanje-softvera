using Microsoft.Data.SqlClient;
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

        public Dogadjaj() { }
        public Dogadjaj(int id, string izvodjac, string hala, string mesto, DateTime datum, double cena)
        {
            Id = id;
            Izvodjac = izvodjac;
            Hala = hala;
            Mesto = mesto;
            Datum = datum;
            Cena = cena;
        }

        public OpstiDomenskiObjekat ProcitajRed(SqlDataReader ulaz)
        {
            Dogadjaj d = new Dogadjaj();
            d.Id = (int)ulaz["id"];
            d.Izvodjac = ulaz["izvodjac"].ToString();
            d.Hala = ulaz["hala"].ToString();
            d.Mesto = ulaz["mesto"].ToString();
            d.Datum = (DateTime)ulaz["datum"];
            d.Cena = (double)ulaz["cena"];

            return d;
        }

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

        public string Uslov()
        {
            return $"id = {Id}";
        }

        public string UslovZaPretragu(string filter)
        {
            return $"LOWER(izvodjac) LIKE CONCAT('%',LOWER('{filter}'),'%')";
        }

        public string Join()
        {
            throw new NotImplementedException();
        }
    }
}
