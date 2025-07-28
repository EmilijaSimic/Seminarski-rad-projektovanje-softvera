using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.SistemskeOperacije.SOZaposleni
{
    internal class PretraziZaposlenog : OpsteIzvrsenjeSO
    {
        public string Filter { get; set; }
        public List<OpstiDomenskiObjekat> Rezultat {  get; set; }
        public PretraziZaposlenog(string filter)
        {
            Filter = filter;
        }

        public override bool izvrsiSO(OpstiDomenskiObjekat odo)
        {
            Zaposleni z = new Zaposleni();
            Rezultat =  bbp.Pretrazi(z, Filter);
            //List<Zaposleni> listaZaposlenih = Rezultat.Cast<Zaposleni>().ToList(); za buducnost
            return true;
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {
            return true;
        }
    }
}
