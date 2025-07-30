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
            izlaz.AutoFlush = true;
        }

        public void Posalji(Zahtev zahtev)
        {
            izlaz.WriteLine(JsonSerializer.Serialize(zahtev));
        }

        public void PosaljiOdgovorKlijentu(Odgovor odgovor) {
            izlaz.WriteLine(JsonSerializer.Serialize(odgovor));
        }

        public void Zatvori()
        {
            izlaz.Close();
        }
    }
}
