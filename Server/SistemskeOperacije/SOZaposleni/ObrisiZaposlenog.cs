using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.SistemskeOperacije.SOZaposleni
{
    internal class ObrisiZaposlenog : OpsteIzvrsenjeSO
    {
        public override bool izvrsiSO(OpstiDomenskiObjekat odo)
        {
            Zaposleni zaposleni = (Zaposleni)odo;
            return bbp.Obrisi(odo);
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {
            if (odo is Zaposleni zaposleni)
            {
                return true;
            }
            return false;
        }
    }
}
