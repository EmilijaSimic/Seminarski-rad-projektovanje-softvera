using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.SistemskeOperacije.SOStavkaPotvrde
{
    internal class VratiListuStavkiPotvrde : OpsteIzvrsenjeSO
    {
        public List<OpstiDomenskiObjekat> Rezultat {  get; set; }
        public string Filter {  get; set; }

        public VratiListuStavkiPotvrde(string filter) {
            Filter = filter;
        }
        public override bool izvrsiSO(OpstiDomenskiObjekat odo)
        {
            Rezultat = bbp.PretraziSaJoin(new StavkaPotvrde(), Filter);
            return true;
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {
            return true;
        }
    }
}
