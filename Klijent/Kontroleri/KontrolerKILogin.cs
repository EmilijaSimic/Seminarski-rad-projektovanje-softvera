using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent.Kontroleri
{
    internal class KontrolerKILogin:OpstiKontrolerKI
    {
        private static KontrolerKILogin instance;

        private KontrolerKILogin() { }

        public static KontrolerKILogin Instanca
        {
            get
            {
                if (instance == null)
                {
                    instance = new KontrolerKILogin();
                }
                return instance;
            }
        }

        public Odgovor IzvrsiLogin(Zaposleni zaposleni)
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.LOGIN;
                zahtev.Podaci = zaposleni;
                PosaljiZahtev(zahtev);
                return PrimiOdgovor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u loginu: " + ex.Message);
            }
            return null;
        }
    }
}
