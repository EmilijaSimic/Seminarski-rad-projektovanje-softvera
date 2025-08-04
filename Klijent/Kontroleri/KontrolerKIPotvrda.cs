using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent.Kontroleri
{
    internal class KontrolerKIPotvrda:OpstiKontrolerKI
    {
        private static KontrolerKIPotvrda instance;

        private KontrolerKIPotvrda() { }

        public static KontrolerKIPotvrda Instanca
        {
            get
            {
                if (instance == null)
                {
                    instance = new KontrolerKIPotvrda();
                }
                return instance;
            }
        }

        public Odgovor KreirajPotvrdu(Potvrda potvrda)
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.KREIRAJ_POTVRDU;
                zahtev.Podaci = potvrda;
                PosaljiZahtev(zahtev);
                return PrimiOdgovor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u kreiranju potvrde: " + ex.Message);
            }
            return null;
        }

        public Odgovor PromeniPotvrdu(Potvrda potvrda)
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.PROMENI_POTVRDU;
                zahtev.Podaci = potvrda;
                PosaljiZahtev(zahtev);
                return PrimiOdgovor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u promeni potvrde: " + ex.Message);
            }
            return null;
        }

        public Odgovor VratiListuPotvrda()
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.VRATI_LISTU_POTVRDA;
                PosaljiZahtev(zahtev);
                Odgovor odgovor = PrimiOdgovor();
                odgovor.Podaci = JsonSerializer.Deserialize<List<Potvrda>>(((JsonElement)odgovor.Podaci).GetRawText());
                return odgovor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u vracanju liste potvrde: " + ex.Message);
            }
            return null;
        }
    }
}
