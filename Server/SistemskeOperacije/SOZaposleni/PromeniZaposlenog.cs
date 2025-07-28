using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.SistemskeOperacije.SOZaposleni
{
    internal class PromeniZaposlenog : OpsteIzvrsenjeSO
    {
        public override bool izvrsiSO(OpstiDomenskiObjekat odo)
        {
            Zaposleni zaposleni = (Zaposleni)odo;
            return bbp.Promeni(zaposleni);
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {
            if (odo is Zaposleni zaposleni)
            {
                if (zaposleni.KorisnickoIme != null && zaposleni.Lozinka != null && zaposleni.Jmbg != null && zaposleni.Ime != null && zaposleni.Prezime != null &&
                    zaposleni.KorisnickoIme != "" && zaposleni.Lozinka != "" && zaposleni.Ime != "" && zaposleni.Prezime != "" &&
                    zaposleni.Jmbg.Length != 13 && zaposleni.Ime[0] == zaposleni.Ime.ToUpper()[0] && zaposleni.Prezime[0] == zaposleni.Prezime.ToUpper()[0])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
