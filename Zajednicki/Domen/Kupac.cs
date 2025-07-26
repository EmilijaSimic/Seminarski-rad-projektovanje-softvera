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
    }
}
