using Server.SistemskeOperacije.SOStavkaPotvrde;
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
                stavka.Cena = stavka.Dogadjaj.Cena;
                stavka.Iznos = stavka.Kolicina * stavka.Cena;
                potvrda.Cena += stavka.Iznos;
            }

            potvrda.IznosUkupno = ((100 - potvrda.Popust) / 100) * potvrda.Cena;

            if (!bbp.Promeni(potvrda))
            {
                return false;
            }

            VratiListuStavkiPotvrde so = new VratiListuStavkiPotvrde(potvrda.Id.ToString());
            so.OpsteIzvrsiSO(potvrda);
            List<StavkaPotvrde> stareStavke = so.Rezultat.Cast<StavkaPotvrde>().ToList();

            foreach (StavkaPotvrde stara in stareStavke)
            {
                if (!potvrda.Stavke.Any(s => s.Rb == stara.Rb))
                {
                    stara.Potvrda = new Potvrda();
                    stara.Potvrda.Id = potvrda.Id;
                    if (!bbp.Obrisi(stara))
                    {
                        return false;
                    }
                }
            }
            int rb = potvrda.Stavke.Max(s => s.Rb)+1;
            foreach (StavkaPotvrde nova in potvrda.Stavke)
            {
                nova.Potvrda= new Potvrda();
                nova.Potvrda.Id = potvrda.Id;

                if (nova.Rb == 0)
                {
                    nova.Rb = rb;
                    rb++;
                    if (!bbp.KreirajZavisneObjekte(nova))
                    {
                        return false;
                    }
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
                    if (potvrda.Datum != null && potvrda.Stavke.Count >= 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
