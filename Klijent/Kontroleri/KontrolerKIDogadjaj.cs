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
    internal class KontrolerKIDogadjaj:OpstiKontrolerKI
    {
        private static KontrolerKIDogadjaj instance;

        private KontrolerKIDogadjaj() { }

        public static KontrolerKIDogadjaj Instanca
        {
            get
            {
                if (instance == null)
                {
                    instance = new KontrolerKIDogadjaj();
                }
                return instance;
            }
        }

        public Odgovor KreirajDogadjaj(Dogadjaj dogadjaj)
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.KREIRAJ_DOGADJAJ;
                zahtev.Podaci = dogadjaj;
                PosaljiZahtev(zahtev);
                return PrimiOdgovor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u kreiranju dogadjaja: "+ex.Message);
            }
            return null;
        }

        public Odgovor ObrisiDogadjaj(Dogadjaj dogadjaj)
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.OBRISI_DOGADJAJ;
                zahtev.Podaci = dogadjaj;
                PosaljiZahtev(zahtev);
                return PrimiOdgovor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u brisanju dogadjaja: " + ex.Message);
            }
            return null;
        }

        public Odgovor PretraziDogadjaj(string filter)
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.PRETRAZI_DOGADJAJ;
                zahtev.Podaci = filter;
                PosaljiZahtev(zahtev);
                Odgovor odgovor = PrimiOdgovor();
                odgovor.Podaci = JsonSerializer.Deserialize<List<Dogadjaj>>(((JsonElement)odgovor.Podaci).GetRawText());
                return odgovor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u brisanju dogadjaja: " + ex.Message);
            }
            return null;
        }

        public Odgovor PromeniDogadjaj(Dogadjaj dogadjaj)
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.PROMENI_DOGADJAJ;
                zahtev.Podaci = dogadjaj;
                PosaljiZahtev(zahtev);
                return PrimiOdgovor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u promeni dogadjaja: " + ex.Message);
            }
            return null;
        }

        public Odgovor VratiListuDogadjaja()
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.VRATI_LISTU_DOGADJAJA;
                PosaljiZahtev(zahtev);
                Odgovor odgovor = PrimiOdgovor();
                odgovor.Podaci = JsonSerializer.Deserialize<List<Dogadjaj>>(((JsonElement)odgovor.Podaci).GetRawText());
                return odgovor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u vracanju liste dogadjaja: " + ex.Message);
            }
            return null;
        }
    }
}
