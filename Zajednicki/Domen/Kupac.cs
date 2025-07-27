using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class Kupac : OpstiDomenskiObjekat
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string BrojPlatneKartice { get; set; }
        public bool Aktivan {  get; set; }
        public TipKupca TipKupca { get; set; }
        public string KorisnickoIme {  get; set; }
        public string Lozinka {  get; set; }

        public OpstiDomenskiObjekat ProcitajRed(SqlDataReader ulaz)
        {
            throw new NotImplementedException();
        }

        public string VratiNaziveKolona()
        {
            return "ime, prezime, telefon, brojPlatneKartice, aktivan, tipKupcaId, korisnickoIme, lozinka";
        }

        public string VratiNazivTabele()
        {
            return "Kupac";
        }

        public string VratiVrednostiKolona()
        {
            return $"'{Ime}', '{Prezime}', '{Telefon}', '{BrojPlatneKartice}', {(Aktivan ? 1 : 0)}, {TipKupca.Id}, '{KorisnickoIme}', '{Lozinka}'";
        }

        public string VratiVrednostiZaPromenu()
        {
            return $"ime = '{Ime}', prezime = '{Prezime}', telefon = '{Telefon}', brojPlatneKartice = '{BrojPlatneKartice}', aktivan = {(Aktivan ? 1 : 0)}, tipKupcaId = {TipKupca.Id}, korisnickoIme = '{KorisnickoIme}', lozinka = '{Lozinka}'";
        }
    }
}
