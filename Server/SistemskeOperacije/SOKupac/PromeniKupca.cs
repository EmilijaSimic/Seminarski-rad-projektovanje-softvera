using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.SistemskeOperacije.SOKupac
{
    internal class PromeniKupca : OpsteIzvrsenjeSO
    {
        public override bool izvrsiSO(OpstiDomenskiObjekat odo)
        {
            Kupac k = (Kupac)odo;
            return bbp.Promeni(k);
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {
            if (odo is Kupac kupac)
            {
                if (kupac.Ime != null && kupac.Prezime != null && kupac.Ime != "" && kupac.Prezime != null && kupac.TipKupca != null &&
                    kupac.Ime[0] == kupac.Ime.ToUpper()[0] && kupac.Prezime[0] == kupac.Prezime.ToUpper()[0])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
