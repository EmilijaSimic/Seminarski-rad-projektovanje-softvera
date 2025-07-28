using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.SistemskeOperacije.SODogadjaj
{
    internal class PretraziDogadjaj : OpsteIzvrsenjeSO
    {
        public string Filter { get; set; }
        public List<OpstiDomenskiObjekat> Rezultat { get; set; }

        public PretraziDogadjaj(string filter)
        {
            Filter = filter;
        }
        public override bool izvrsiSO(OpstiDomenskiObjekat odo)
        {
            Dogadjaj d = new Dogadjaj();
            Rezultat = bbp.Pretrazi(d, Filter);
            return true;
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {
            return true;
        }
    }
}
