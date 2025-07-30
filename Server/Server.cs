using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Server
    {
        Socket serverskiSoket;
        List<ObradaZahtevaKlijenta> klijenti = new List<ObradaZahtevaKlijenta> ();

        public Server() {
            serverskiSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Osluskuj()
        {
            serverskiSoket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
            serverskiSoket.Listen();
        }

        public void Pokreni()
        {
            try
            {
                while (true)
                {
                    Socket klijentskiSoket = serverskiSoket.Accept();
                    ObradaZahtevaKlijenta klijent = new ObradaZahtevaKlijenta(klijentskiSoket, this);
                    klijenti.Add(klijent);
                    Thread nit = new Thread(klijent.ObradiZahteve);
                    nit.IsBackground = true;
                    nit.Start();
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
        }

        public void Zaustavi()
        {
            if (serverskiSoket != null)
            {
                serverskiSoket.Close();
                foreach (ObradaZahtevaKlijenta klijent in klijenti)
                {
                    klijent.Zaustavi();
                }
            }
        }

        public void UkloniKlijenta(ObradaZahtevaKlijenta klijent)
        {
            klijenti.Remove(klijent);
        }
    }
}
