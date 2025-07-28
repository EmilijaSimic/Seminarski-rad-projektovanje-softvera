using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.SistemskeOperacije.SOPotvrda
{
    internal class PromeniPotvrdu : OpsteIzvrsenjeSO
    {
        public override bool izvrsiSO(OpstiDomenskiObjekat odo)
        {
            Potvrda potvrda = (Potvrda)odo;

            potvrda.Cena = 0;
            foreach (StavkaPotvrde stavka in potvrda.Stavke)
            {
                potvrda.Cena += stavka.Iznos;
            }

            potvrda.Popust = potvrda.Kupac.TipKupca.Popust;
            potvrda.IznosUkupno = (1 - potvrda.Popust) * potvrda.Cena;

            if (!bbp.Promeni(potvrda))
            {
                return false;
            }

            foreach (StavkaPotvrde stavka in potvrda.Stavke)
            {
                stavka.Potvrda.Id = potvrda.Id;
                if (!bbp.Promeni(stavka))
                {
                    return false;
                }
            }

            return true;
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {
            if (odo is Potvrda potvrda)
            {
                if (potvrda.Stavke != null && potvrda.Kupac != null && potvrda.Zaposleni != null)
                {
                    if (potvrda.Datum != null && potvrda.Stavke.Count > 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
