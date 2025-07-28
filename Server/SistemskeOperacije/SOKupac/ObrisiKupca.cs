using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.SistemskeOperacije.SOKupac
{
    internal class ObrisiKupca : OpsteIzvrsenjeSO
    {
        public override bool izvrsiSO(OpstiDomenskiObjekat odo)
        {
            Kupac kupac = new Kupac();
            return bbp.Obrisi(kupac);
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {
            if (odo is Kupac kupac)
            {
                return true;
            }
            return false;
        }
    }
}
