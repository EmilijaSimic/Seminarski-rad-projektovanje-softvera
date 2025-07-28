using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.SistemskeOperacije.SOKupac
{
    internal class PretraziKupca : OpsteIzvrsenjeSO
    {
        public string Filter { get; set; }
        List<OpstiDomenskiObjekat> Rezultat;
        public override bool izvrsiSO(OpstiDomenskiObjekat odo)
        {
            Rezultat = bbp.PretraziSaJoin(new Kupac(), Filter);
            return true;
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {
            return true;
        }
    }
}
