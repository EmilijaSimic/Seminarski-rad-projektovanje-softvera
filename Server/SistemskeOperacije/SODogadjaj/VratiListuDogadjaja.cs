using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.SistemskeOperacije.SODogadjaj
{
    internal class VratiListuDogadjaja : OpsteIzvrsenjeSO
    {
        public List<OpstiDomenskiObjekat> Rezultat { get; set; }

        public override bool izvrsiSO(OpstiDomenskiObjekat odo)
        {
            Rezultat = bbp.VratiListuSvih(new Dogadjaj());
            return true;
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {
            return true;
        }
    }
}
