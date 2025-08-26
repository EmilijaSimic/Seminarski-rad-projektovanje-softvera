using Microsoft.Data.SqlClient;
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

        public StavkaPotvrde() { }
        public StavkaPotvrde(int rb, Potvrda potvrda, int kolicina, double cena, double iznos, Dogadjaj dogadjaj)
        {
            Rb = rb;
            Potvrda = potvrda;
            Kolicina = kolicina;
            Cena = cena;
            Iznos = iznos;
            Dogadjaj = dogadjaj;
        }

        public string Join()
        {
            return "s join Dogadjaj d on (s.idDogadjaj = d.id)";
        }

        public OpstiDomenskiObjekat ProcitajRed(SqlDataReader ulaz)
        {
            StavkaPotvrde sp = new StavkaPotvrde();
            sp.Rb = (int)ulaz["rb"];
            sp.Kolicina = (int)ulaz["kolicina"];
            sp.Cena = (double)ulaz["cena"];
            sp.Iznos = (double)ulaz["iznos"];

            Dogadjaj d = new Dogadjaj();
            d.Id = (int)ulaz["idDogadjaj"]; 
            d.Izvodjac = ulaz["izvodjac"].ToString();
            d.Hala = ulaz["hala"].ToString();
            d.Mesto = ulaz["mesto"].ToString();
            d.Datum = (DateTime)ulaz["datum"];
            d.Cena = (double)ulaz["cena"]; 

            sp.Dogadjaj = d;
            return sp;
        }

        public string Uslov()
        {
            return $"rb = {Rb} AND idPotvrda = {Potvrda.Id}";
        }

        public string UslovZaPretragu(string filter)
        {
            return $"idPotvrda = {int.Parse(filter)}";

        }

        public string VratiNaziveKolona()
        {
            return "rb, idPotvrda, kolicina, cena, iznos, idDogadjaj";
        }

        public string VratiNazivTabele()
        {
            return "StavkaPotvrde";
        }

        public string VratiVrednostiKolona()
        {
            return $"{Rb}, {Potvrda.Id}, {Kolicina}, {Cena.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {Iznos.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {Dogadjaj.Id}";
        }

        public string VratiVrednostiZaPromenu()
        {
            return $"idPotvrda = {Potvrda.Id}, kolicina = {Kolicina}, cena = {Cena.ToString(System.Globalization.CultureInfo.InvariantCulture)}, iznos = {Iznos.ToString(System.Globalization.CultureInfo.InvariantCulture)}, idDogadjaj = {Dogadjaj.Id}";
        }

    }
}
