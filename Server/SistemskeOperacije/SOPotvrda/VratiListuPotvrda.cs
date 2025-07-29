using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.SistemskeOperacije.SOPotvrda
{
    internal class VratiListuPotvrda : OpsteIzvrsenjeSO
    {
        public List<OpstiDomenskiObjekat> Rezultat {  get; set; }
        public override bool izvrsiSO(OpstiDomenskiObjekat odo)
        {
            Rezultat = bbp.VratiListuSvihSaJoin(new Potvrda());
            return true;
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {
            return true;
        }
    }
}
