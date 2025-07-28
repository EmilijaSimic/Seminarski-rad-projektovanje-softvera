using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.SistemskeOperacije.SOTipKupca
{
    internal class PromeniTipKupca : OpsteIzvrsenjeSO
    {
        public override bool izvrsiSO(OpstiDomenskiObjekat odo)
        {
            TipKupca tip = (TipKupca) odo;
            return bbp.Promeni(tip);
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {
            if (odo is TipKupca tip)
            {
                if (tip.Naziv != null && tip.Naziv != "")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
