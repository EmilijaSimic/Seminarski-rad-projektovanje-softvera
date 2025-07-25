using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Zajednicki.Komunikacija
{
    public class Posiljalac
    {
        private StreamWriter izlaz;
        public Posiljalac(Socket socket) { 
            NetworkStream stream = new NetworkStream(socket);
            izlaz = new StreamWriter(stream);
        }

        public void Posalji(Zahtev zahtev)
        {
            izlaz.WriteLine(JsonSerializer.Serialize(zahtev));
        }

        public void Zatvori()
        {
            izlaz.Close();
        }
    }
}
