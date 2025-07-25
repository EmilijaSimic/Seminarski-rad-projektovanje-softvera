using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class ObradaZahtevaKlijenta
    {
        Socket socket;
        Server server;

        public ObradaZahtevaKlijenta(Socket socket, Server server) {
            this.socket = socket;
            this.server = server;
        }

        public void ObradiZahteve()
        {
            try
            {
                while (true)
                {

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

        public void Zaustavi()
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }
}
