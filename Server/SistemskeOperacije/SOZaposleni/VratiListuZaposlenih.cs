using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.SistemskeOperacije.SOZaposleni
{
    internal class VratiListuZaposlenih : OpsteIzvrsenjeSO
    {
        public string Filter { get; set; }
        public List<OpstiDomenskiObjekat> Rezultat { get; set; }

        public VratiListuZaposlenih(string filter) {
            Filter = filter;
        }

        public override bool izvrsiSO(OpstiDomenskiObjekat odo)
        {
            //DOPUNI
            return true;
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {
            return true;
        }
    }
}
