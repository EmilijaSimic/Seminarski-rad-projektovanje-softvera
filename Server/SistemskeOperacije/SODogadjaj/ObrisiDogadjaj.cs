using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.SistemskeOperacije.SODogadjaj
{
    internal class ObrisiDogadjaj : OpsteIzvrsenjeSO
    {
        public override bool izvrsiSO(OpstiDomenskiObjekat odo)
        {
            Dogadjaj d = (Dogadjaj)odo;
            return bbp.Obrisi(d);
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {
            if(odo is Dogadjaj)
            {
                return true;
            }

            return false;
        }
    }
}
