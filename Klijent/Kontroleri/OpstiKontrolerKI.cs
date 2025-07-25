using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Komunikacija;

namespace Klijent.Kontroleri
{
    internal class OpstiKontrolerKI
    {
        Socket socket;
        Posiljalac posiljalac;
        Primalac primalac;

        public OpstiKontrolerKI()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9999);
                posiljalac = new Posiljalac(socket);
                primalac = new Primalac(socket);
            } catch (IOException ex) {
                Debug.WriteLine(">>> " + ex.Message);
            }
        }

        public void PosaljiZahtev(Zahtev zahtev)
        {
            try
            {
                posiljalac.Posalji(zahtev);
            }
            catch (IOException ex) {
                Debug.WriteLine(">>> " + ex.Message);
            }
        }

        public Odgovor PrimiOdgovor()
        {
            try
            {
                return primalac.Primi();
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>> " + ex.Message);
            }
            return null;
        }
    }
}
