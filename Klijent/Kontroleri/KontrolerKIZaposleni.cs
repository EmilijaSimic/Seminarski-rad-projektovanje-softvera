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
    internal class KontrolerKIZaposleni:OpstiKontrolerKI
    {
        private static KontrolerKIZaposleni instance;

        private KontrolerKIZaposleni() { }

        public static KontrolerKIZaposleni Instanca
        {
            get
            {
                if (instance == null)
                {
                    instance = new KontrolerKIZaposleni();
                }
                return instance;
            }
        }

        public Odgovor KreirajZaposlenog(Zaposleni zaposleni)
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.KREIRAJ_ZAPOSLENOG;
                zahtev.Podaci = zaposleni;
                PosaljiZahtev(zahtev);
                return PrimiOdgovor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u kreiranju zaposlenog: " + ex.Message);
            }
            return null;
        }

        public Odgovor ObrisiZaposlenog(Zaposleni zaposleni)
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.OBRISI_ZAPOSLENOG;
                zahtev.Podaci = zaposleni;
                PosaljiZahtev(zahtev);
                return PrimiOdgovor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u brisanju zaposlenog: " + ex.Message);
            }
            return null;
        }

        public Odgovor PretraziZaposlenog(string filter)
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.PRETRAZI_ZAPOSLENOG;
                zahtev.Podaci = filter;
                PosaljiZahtev(zahtev);
                Odgovor odgovor = PrimiOdgovor();
                odgovor.Podaci = JsonSerializer.Deserialize<List<Zaposleni>>(((JsonElement)odgovor.Podaci).GetRawText());
                return odgovor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u pretrazivanju zaposlenog: " + ex.Message);
            }
            return null;
        }

        public Odgovor PromeniZaposlenog(Zaposleni zaposleni)
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.PROMENI_ZAPOSLENOG;
                zahtev.Podaci = zaposleni;
                PosaljiZahtev(zahtev);
                return PrimiOdgovor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u promeni zaposlenog: " + ex.Message);
            }
            return null;
        }

        public Odgovor VratiListuZaposlenih()
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.VRATI_LISTU_ZAPOSLENIH;
                PosaljiZahtev(zahtev);
                Odgovor odgovor = PrimiOdgovor();
                odgovor.Podaci = JsonSerializer.Deserialize<List<Zaposleni>>(((JsonElement)odgovor.Podaci).GetRawText());
                return odgovor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u vracanju liste zaposlenih: " + ex.Message);
            }
            return null;
        }
    }
}
