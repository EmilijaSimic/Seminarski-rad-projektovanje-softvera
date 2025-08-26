using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.SistemskeOperacije.SOPotvrda
{
    internal class KreirajPotvrdu : OpsteIzvrsenjeSO
    {
        public override bool izvrsiSO(OpstiDomenskiObjekat odo)
        {
            Potvrda potvrda = (Potvrda)odo;

            VratiListuPotvrda so = new VratiListuPotvrda();
            so.OpsteIzvrsiSO(potvrda);
            List<Potvrda> potvrde = so.Rezultat.Cast<Potvrda>().ToList(); ;

            foreach (Potvrda p in potvrde) {
                if (p.Kupac.Id == potvrda.Kupac.Id && p.Zaposleni.Id==potvrda.Zaposleni.Id) {
                    return false;
                }
            }

            potvrda.Cena = 0;
            foreach (StavkaPotvrde stavka in potvrda.Stavke)
            {
                stavka.Cena = stavka.Dogadjaj.Cena;
                stavka.Iznos = stavka.Kolicina * stavka.Cena;
                potvrda.Cena += stavka.Iznos;
            }

            potvrda.Popust = potvrda.Kupac.TipKupca.Popust;
            potvrda.IznosUkupno = ((100 - potvrda.Popust)/100) * potvrda.Cena;

            if (!bbp.Kreiraj(potvrda))
            {
                return false;
            }

            foreach (StavkaPotvrde stavka in potvrda.Stavke)
            {
                stavka.Potvrda.Id = potvrda.Id;
                if (!bbp.KreirajZavisneObjekte(stavka))
                {
                    return false;
                }
            }

            return true;
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {
            if(odo is Potvrda potvrda)
            {
                if (potvrda.Stavke != null && potvrda.Kupac != null && potvrda.Zaposleni != null) { 
                    if(potvrda.Datum != null && potvrda.Stavke.Count >= 1 )
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
