using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class Zaposleni : OpstiDomenskiObjekat
    {
        public int Id { get; set; }
        public string Jmbg { get; set; }
        public string Ime { get; set; }
        public string Prezime {  get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public Zaposleni() { }
        public Zaposleni(int id, string jmbg, string ime, string prezime, string korisnickoIme, string lozinka)
        {
            Id = id;
            Jmbg = jmbg;
            Ime = ime;
            Prezime = prezime;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
        }

        public OpstiDomenskiObjekat ProcitajRed(SqlDataReader ulaz)
        {
            Zaposleni z = new Zaposleni();
            z.Id = (int)ulaz["id"];
            z.Jmbg = ulaz["jmbg"].ToString();
            z.Ime = ulaz["ime"].ToString();
            z.Prezime = ulaz["prezime"].ToString();
            z.KorisnickoIme = ulaz["korisnickoIme"].ToString();
            z.Lozinka = ulaz["lozinka"].ToString();

            return z;
        }

        public string VratiNaziveKolona()
        {
            return "jmbg, ime, prezime, korisnickoIme, lozinka";
        }

        public string VratiNazivTabele()
        {
            return "Zaposleni";
        }

        public string VratiVrednostiKolona()
        {
            return $"'{Jmbg}', '{Ime}', '{Prezime}', '{KorisnickoIme}', '{Lozinka}'";
        }

        public string VratiVrednostiZaPromenu()
        {
             return $"jmbg = '{Jmbg}', ime = '{Ime}', prezime = '{Prezime}', korisnickoIme = '{KorisnickoIme}', lozinka = '{Lozinka}'";
        }

        public string Uslov()
        {
            return $"id = {Id}";
        }

        public string UslovZaPretragu(string filter)
        {
            return $"LOWER(ime) LIKE CONCAT('%',LOWER('{filter}'),'%')";
        }

        public string Join()
        {
            throw new NotImplementedException();
        }
    }
}
