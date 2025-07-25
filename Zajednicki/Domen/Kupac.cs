using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    internal class Kupac
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string BrojPlatneKartice { get; set; }
        public bool Aktivan {  get; set; }
        public TipKupca TipKupca { get; set; }
    }
}
