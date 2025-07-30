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

        public Kupac() { }
        public Kupac(int id, string ime, string prezime, string telefon, string brojPlatneKratice, bool aktivan, TipKupca tipKupca) {
            Id = id;
            Ime = ime;
            Prezime = prezime;
            Telefon = telefon;
            BrojPlatneKartice = brojPlatneKratice;
            Aktivan = aktivan;
            TipKupca = tipKupca;
        }

        public string Join()
        {
            return "k JOIN TipKupca tk on (k.idTipKupca = tk.id)";
        }

        public OpstiDomenskiObjekat ProcitajRed(SqlDataReader ulaz)
        {
            Kupac k = new Kupac();
            k.Id = (int)ulaz[0];
            k.Ime = ulaz["ime"].ToString();
            k.Prezime = ulaz["prezime"].ToString();
            k.Telefon = ulaz["telefon"].ToString();
            k.BrojPlatneKartice = ulaz["brojPlatneKartice"].ToString();
            k.Aktivan = (bool)ulaz["aktivan"];
            k.TipKupca = new TipKupca();
            k.TipKupca.Id = (int)ulaz["idTipKupca"];
            k.TipKupca.Naziv = ulaz["naziv"].ToString();
            k.TipKupca.Popust = (double)ulaz["popust"];

            return k;
        }

        public string Uslov()
        {
            throw new NotImplementedException();
        }

        public string UslovZaPretragu(string filter)
        {
            return $"LOWER(ime) LIKE CONCAT('%',LOWER('{filter}'),'%')";
        }

        public string VratiNaziveKolona()
        {
            return "ime, prezime, telefon, brojPlatneKartice, aktivan, IdTipKupca";
        }

        public string VratiNazivTabele()
        {
            return "Kupac";
        }

        public string VratiVrednostiKolona()
        {
            return $"'{Ime}', '{Prezime}', '{Telefon}', '{BrojPlatneKartice}', {(Aktivan ? 1 : 0)}, {TipKupca.Id}";
        }

        public string VratiVrednostiZaPromenu()
        {
            return $"ime = '{Ime}', prezime = '{Prezime}', telefon = '{Telefon}', brojPlatneKartice = '{BrojPlatneKartice}', aktivan = {(Aktivan ? 1 : 0)}, idTipKupca = {TipKupca.Id}";
        }

    }
}
