using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.SistemskeOperacije.SODogadjaj
{
    public class KreirajDogadjaj : OpsteIzvrsenjeSO
    {
        public override bool izvrsiSO(OpstiDomenskiObjekat odo)
        {
            Dogadjaj d = (Dogadjaj)odo;
            return bbp.Kreiraj(d);
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {
            if (odo is Dogadjaj dogadjaj) {
                if (dogadjaj.Izvodjac != null && dogadjaj.Datum != null && dogadjaj.Cena > 0) {
                    return true;
                }
            }
            return false;
        }
    }
}
