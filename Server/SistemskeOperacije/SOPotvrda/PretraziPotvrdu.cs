using Server.SistemskeOperacije.SOStavkaPotvrde;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.SistemskeOperacije.SOPotvrda
{
    internal class PretraziPotvrdu: OpsteIzvrsenjeSO
    {
        public Potvrda Rezultat = null;
        public override bool izvrsiSO(OpstiDomenskiObjekat odo)
        {
            Potvrda potvrda = (Potvrda)odo;
            VratiListuPotvrda so = new VratiListuPotvrda();
            so.OpsteIzvrsiSO(new Potvrda());
            List<Potvrda> potvrde = so.Rezultat.Cast<Potvrda>().ToList();

            foreach (Potvrda p in potvrde)
            {
                if (p.Kupac.Id == potvrda.Kupac.Id && p.Zaposleni.Id == potvrda.Zaposleni.Id)
                {
                    VratiListuStavkiPotvrde so2 = new VratiListuStavkiPotvrde(p.Id.ToString());
                    so2.OpsteIzvrsiSO(potvrda);
                    p.Stavke = so2.Rezultat.Cast<StavkaPotvrde>().ToList();
                    Rezultat = p;
                    return true;
                }
            }
            return false;
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {
            if (odo is Potvrda potvrda)
            {
                if (potvrda.Kupac != null && potvrda.Zaposleni != null 
                    && potvrda.Kupac.Id != 0 && potvrda.Zaposleni.Id != 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
