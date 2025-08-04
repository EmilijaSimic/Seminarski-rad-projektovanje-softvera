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
    internal class KontrolerKIPozicija:OpstiKontrolerKI
    {
        private static KontrolerKIPozicija instance;

        private KontrolerKIPozicija() { }

        public static KontrolerKIPozicija Instanca
        {
            get
            {
                if (instance == null)
                {
                    instance = new KontrolerKIPozicija();
                }
                return instance;
            }
        }

        public Odgovor PromeniPoziciju(Pozicija pozicija)
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.PROMENI_POZICIJU;
                zahtev.Podaci = pozicija;
                PosaljiZahtev(zahtev);
                return PrimiOdgovor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u promeni pozicije: " + ex.Message);
            }
            return null;
        }

        public Odgovor VratiListuPozicija()
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.VRATI_LISTU_POZICIJA;
                PosaljiZahtev(zahtev);
                Odgovor odgovor = PrimiOdgovor();
                odgovor.Podaci = JsonSerializer.Deserialize<List<Pozicija>>(((JsonElement)odgovor.Podaci).GetRawText());
                return odgovor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u promeni pozicije: " + ex.Message);
            }
            return null;
        }
    }
}
