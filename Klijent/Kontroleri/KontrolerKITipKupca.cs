using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent.Kontroleri
{
    internal class KontrolerKITipKupca:OpstiKontrolerKI
    {
        private static KontrolerKITipKupca instance;

        private KontrolerKITipKupca() { }

        public static KontrolerKITipKupca Instanca
        {
            get
            {
                if (instance == null)
                {
                    instance = new KontrolerKITipKupca();
                }
                return instance;
            }
        }

        public Odgovor PromeniTipKupca(TipKupca tip)
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.PROMENI_TIP_KUPCA;
                zahtev.Podaci = tip;
                PosaljiZahtev(zahtev);
                return PrimiOdgovor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u promeni tipa kupca: " + ex.Message);
            }
            return null;
        }

        public Odgovor VratiListuTipKupaca()
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.VRATI_LISTU_TIP_KUPACA;
                PosaljiZahtev(zahtev);
                return PrimiOdgovor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u vrati listu tipa kupca: " + ex.Message);
            }
            return null;
        }
    }
}
