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
    }
}
