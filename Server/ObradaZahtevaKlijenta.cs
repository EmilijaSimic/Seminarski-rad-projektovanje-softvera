﻿using System;
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
            switch (zahtev.Operacija)
            {
                case(Operacija.LOGIN):
                    JsonElement jsonElement = (JsonElement)zahtev.Podaci;
                    Zaposleni zaposleni = JsonSerializer.Deserialize<Zaposleni>(jsonElement.GetRawText());
                    Odgovor odgovor = new Odgovor();
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
