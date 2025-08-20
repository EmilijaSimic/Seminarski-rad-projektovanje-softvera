using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Server
{
    internal class ObradaZahtevaKlijenta
    {
        static List<Zaposleni> ulogovaniZaposleni = new List<Zaposleni>();
        Socket socket;
        Server server;
        Posiljalac posiljalac;
        Primalac primalac;

        public ObradaZahtevaKlijenta(Socket socket, Server server) {
            this.socket = socket;
            this.server = server;
            posiljalac = new Posiljalac(socket);
            primalac = new Primalac(socket);
        }

        public void ObradiZahteve()
        {
            try
            {
                while (true)
                {
                    Zahtev zahtev = primalac.PrimiZahtevOdKlijenta();
                    ObradiZahtev(zahtev);
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>> Greska u citanju ili slanju: " + ex.Message);
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>> Zatvorena konekcija sa klijentom: " + ex.Message);
            }
            finally
            {
                server.UkloniKlijenta(this);
            }
        }

        private void ObradiZahtev(Zahtev zahtev)
        {
            Kontroler kontroler = Kontroler.Instance;
            Odgovor odgovor = new Odgovor();
            switch (zahtev.Operacija)
            {
                case(Operacija.LOGIN):
                    Zaposleni zaposleni = JsonSerializer.Deserialize<Zaposleni>(((JsonElement)zahtev.Podaci).GetRawText());
                    if(kontroler.Login(zaposleni) && !VecUlogovan(zaposleni))
                    {
                        ulogovaniZaposleni.Add(zaposleni);
                        odgovor.Uspesno = true;
                    }
                    else
                    {
                        odgovor.Uspesno=false;
                    }
                    posiljalac.PosaljiOdgovorKlijentu(odgovor);
                break;
                case (Operacija.VRATI_LISTU_DOGADJAJA):
                    odgovor.Uspesno = true;
                    odgovor.Podaci = kontroler.VratiListuDogadjaja();
                    posiljalac.PosaljiOdgovorKlijentu(odgovor);
                break;
                case (Operacija.KREIRAJ_DOGADJAJ):
                    Dogadjaj dogadjajNovi = JsonSerializer.Deserialize<Dogadjaj>(((JsonElement)zahtev.Podaci).GetRawText());
                    odgovor.Uspesno = kontroler.KreirajDogadjaj(dogadjajNovi);
                    posiljalac.PosaljiOdgovorKlijentu(odgovor);
                break;
                case (Operacija.OBRISI_DOGADJAJ):
                    Dogadjaj dogadjajObr = JsonSerializer.Deserialize<Dogadjaj>(((JsonElement)zahtev.Podaci).GetRawText());
                    odgovor.Uspesno = kontroler.ObrisiDogadjaj(dogadjajObr);
                    posiljalac.PosaljiOdgovorKlijentu(odgovor);
                break;
                case (Operacija.PROMENI_DOGADJAJ):
                    Dogadjaj dogadjajPr = JsonSerializer.Deserialize<Dogadjaj>(((JsonElement)zahtev.Podaci).GetRawText());
                    odgovor.Uspesno = kontroler.PromeniDogadjaj(dogadjajPr);
                    posiljalac.PosaljiOdgovorKlijentu(odgovor);
                break;
                case (Operacija.PRETRAZI_DOGADJAJ):
                    string filterDogadjaj = JsonSerializer.Deserialize<string>(((JsonElement)zahtev.Podaci).GetRawText());
                    odgovor.Podaci = kontroler.PretraziDogadjaj(filterDogadjaj);
                    odgovor.Uspesno = true;
                    posiljalac.PosaljiOdgovorKlijentu(odgovor);
                break;
                case (Operacija.VRATI_LISTU_TIP_KUPACA):
                    odgovor.Uspesno = true;
                    odgovor.Podaci = kontroler.VratiListuTipKupaca();
                    posiljalac.PosaljiOdgovorKlijentu(odgovor);
                break;
                case (Operacija.KREIRAJ_KUPCA):
                    Kupac kupacNovi = JsonSerializer.Deserialize<Kupac>(((JsonElement)zahtev.Podaci).GetRawText());
                    odgovor.Uspesno = kontroler.KreirajKupca(kupacNovi);
                    posiljalac.PosaljiOdgovorKlijentu(odgovor);
                break;
                case (Operacija.OBRISI_KUPCA):
                    Kupac kupacObr = JsonSerializer.Deserialize<Kupac>(((JsonElement)zahtev.Podaci).GetRawText());
                    odgovor.Uspesno = kontroler.ObrisiKupca(kupacObr);
                    posiljalac.PosaljiOdgovorKlijentu(odgovor);
                break;
                case (Operacija.PROMENI_KUPCA):
                    Kupac kupacPr = JsonSerializer.Deserialize<Kupac>(((JsonElement)zahtev.Podaci).GetRawText());
                    odgovor.Uspesno = kontroler.PromeniKupca(kupacPr);
                    posiljalac.PosaljiOdgovorKlijentu(odgovor);
                break;
                case (Operacija.PRETRAZI_KUPCA):
                    string filterKupac = JsonSerializer.Deserialize<string>(((JsonElement)zahtev.Podaci).GetRawText());
                    odgovor.Podaci = kontroler.PretraziKupca(filterKupac);
                    odgovor.Uspesno = true;
                    posiljalac.PosaljiOdgovorKlijentu(odgovor);
                break;
                case (Operacija.VRATI_LISTU_KUPACA):
                    odgovor.Uspesno = true;
                    odgovor.Podaci = kontroler.VratiListuKupaca();
                    posiljalac.PosaljiOdgovorKlijentu(odgovor);
                break;
                case (Operacija.VRATI_LISTU_ZAPOSLENIH):
                    odgovor.Uspesno = true;
                    odgovor.Podaci = kontroler.VratiListuZaposlenih(null);
                    posiljalac.PosaljiOdgovorKlijentu(odgovor);
                break;
                    case (Operacija.VRATI_LISTU_POZICIJA):
                    odgovor.Uspesno = true;
                    odgovor.Podaci = kontroler.VratiListuPozicija();
                    posiljalac.PosaljiOdgovorKlijentu(odgovor);
                break;
                case (Operacija.KREIRAJ_ZAPOSLENOG):
                    Zaposleni zaposleniNovi = JsonSerializer.Deserialize<Zaposleni>(((JsonElement)zahtev.Podaci).GetRawText());
                    odgovor.Uspesno = kontroler.KreirajZaposlenog(zaposleniNovi);
                    posiljalac.PosaljiOdgovorKlijentu(odgovor);
                break;
                case (Operacija.OBRISI_ZAPOSLENOG):
                    Zaposleni zaposleniObr = JsonSerializer.Deserialize<Zaposleni>(((JsonElement)zahtev.Podaci).GetRawText());
                    odgovor.Uspesno = kontroler.ObrisiZaposlenog(zaposleniObr);
                    posiljalac.PosaljiOdgovorKlijentu(odgovor);
                break;
                case (Operacija.PROMENI_ZAPOSLENOG):
                    Zaposleni zaposleniPr = JsonSerializer.Deserialize<Zaposleni>(((JsonElement)zahtev.Podaci).GetRawText());
                    odgovor.Uspesno = kontroler.PromeniZaposlenog(zaposleniPr);
                    posiljalac.PosaljiOdgovorKlijentu(odgovor);
                break;
            }
        }

        private bool VecUlogovan(Zaposleni zaposleni)
        {
            foreach (Zaposleni z in ulogovaniZaposleni)
            {
                if(z.KorisnickoIme == zaposleni.KorisnickoIme && z.Lozinka == zaposleni.Lozinka)
                {
                    return true;
                }
            }
            return false;
        }
        public void Zaustavi()
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }
}
