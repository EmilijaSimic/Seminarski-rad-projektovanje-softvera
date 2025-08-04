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
    internal class KontrolerKIKupac:OpstiKontrolerKI
    {
        private static KontrolerKIKupac instance;

        private KontrolerKIKupac() { }

        public static KontrolerKIKupac Instanca
        {
            get
            {
                if (instance == null)
                {
                    instance = new KontrolerKIKupac();
                }
                return instance;
            }
        }

        public Odgovor KreirajKupca(Kupac kupac)
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.KREIRAJ_KUPCA;
                zahtev.Podaci = kupac;
                PosaljiZahtev(zahtev);
                return PrimiOdgovor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u kreiranju kupca: " + ex.Message);
            }
            return null;
        }

        public Odgovor ObrisiKupca(Kupac kupac)
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.OBRISI_KUPCA;
                zahtev.Podaci = kupac;
                PosaljiZahtev(zahtev);
                return PrimiOdgovor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u brisanju kupca: " + ex.Message);
            }
            return null;
        }

        public Odgovor PretraziKupca(string filter)
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.PRETRAZI_KUPCA;
                zahtev.Podaci = filter;
                PosaljiZahtev(zahtev);
                Odgovor odgovor = PrimiOdgovor();
                odgovor.Podaci = JsonSerializer.Deserialize<List<Kupac>>(((JsonElement)odgovor.Podaci).GetRawText());
                return odgovor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u pretrazivanju kupca: " + ex.Message);
            }
            return null;
        }

        public Odgovor PromeniKupca(Kupac kupac)
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.PROMENI_KUPCA;
                zahtev.Podaci = kupac;
                PosaljiZahtev(zahtev);
                return PrimiOdgovor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u promeni kupca: " + ex.Message);
            }
            return null;
        }

        public Odgovor VratiListuKupaca()
        {
            try
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Operacija = Operacija.VRATI_LISTU_KUPACA;
                PosaljiZahtev(zahtev);
                Odgovor odgovor = PrimiOdgovor();
                odgovor.Podaci = JsonSerializer.Deserialize<List<Kupac>>(((JsonElement)odgovor.Podaci).GetRawText());
                return odgovor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>> Greska u vracanju liste kupca: " + ex.Message);
            }
            return null;
        }
    }
}
