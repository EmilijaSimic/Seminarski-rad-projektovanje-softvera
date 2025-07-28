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

        public string Join()
        {
            return "s join Dogadjaj d on (s.idDogadjaj = d.id)";
        }

        public OpstiDomenskiObjekat ProcitajRed(SqlDataReader ulaz)
        {
            StavkaPotvrde sp = new StavkaPotvrde();
            sp.Rb = (int)ulaz["rb"];
            sp.Kolicina = (int)ulaz["kolicina"];
            sp.Cena = (double)ulaz["cena"].ToString();
            sp.Iznos = (double)ulaz["iznos"].ToString();
            sp.IdDogadjaj = (int)ulaz["idDogadjaj"];

            Dogadjaj d = new Dogadjaj();
            d.Id = (int)ulaz["id"]; 
            d.Izvodjac = ulaz["izvodjac"].ToString();
            d.Hala = reader["hala"].ToString();
            d.Mesto = reader["mesto"].ToString();
            d.Datum = reader["datum"].ToString();
            d.Cena = reader["cena1"].ToString(); 

            sp.Dogadjaj = d;
        }

        public string Uslov()
        {
            return $"id = {Rb}";
        }

        public string UslovZaPretragu(string filter)
        {
            return $"idPotvrda = {int.Parse(filter)}";

        }

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
