using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.SistemskeOperacije.SOTipKupca
{
    internal class VratiListuTipKupaca : OpsteIzvrsenjeSO
    {
        List<OpstiDomenskiObjekat> Rezultat {  get; set; }
        public override bool izvrsiSO(OpstiDomenskiObjekat odo)
        {
            Rezultat = bbp.VratiListuSvih(new TipKupca());
            return true;
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {
            return true;
        }
    }
}
