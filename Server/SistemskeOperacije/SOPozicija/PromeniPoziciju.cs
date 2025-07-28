using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.SistemskeOperacije.SOPozicija
{
    internal class PromeniPoziciju : OpsteIzvrsenjeSO
    {
        public override bool izvrsiSO(OpstiDomenskiObjekat odo)
        {
            Pozicija p = (Pozicija)odo;
            return bbp.Promeni(p);
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {
            if (odo is Pozicija pozicija) { 
                if(pozicija.Naziv !=null && pozicija.Naziv != "")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
