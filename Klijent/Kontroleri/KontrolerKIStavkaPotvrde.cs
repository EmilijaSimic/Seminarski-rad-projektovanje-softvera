using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent.Kontroleri
{
    internal class KontrolerKIStavkaPotvrde:OpstiKontrolerKI
    {
        private static KontrolerKIStavkaPotvrde instance;

        private KontrolerKIStavkaPotvrde() { }

        public static KontrolerKIStavkaPotvrde Instanca
        {
            get
            {
                if (instance == null)
                {
                    instance = new KontrolerKIStavkaPotvrde();
                }
                return instance;
            }
        }

        public Odgovor VratiListuStavkiPotvrde()
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.VRATI_LISTU_STAVKI_POTVRDE;
                PosaljiZahtev(zahtev);
                return PrimiOdgovor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u vracanju liste stavki: " + ex.Message);
            }
            return null;
        }
    }
}
