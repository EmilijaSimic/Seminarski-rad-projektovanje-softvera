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
            if (Filter == null)
            {
                Rezultat = bbp.VratiListuSvih(new Zaposleni());
                foreach(Zaposleni z in Rezultat)
                {
                    z.Pozicije = bbp.Pretrazi(new PozicijaZaposlenog(), z.Id.ToString()).Cast<PozicijaZaposlenog>().ToList(); ;
                }
            }
            else
            {
                Rezultat = bbp.Pretrazi(new Zaposleni(), Filter);
            }
                return true;
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {
            return true;
        }
    }
}
