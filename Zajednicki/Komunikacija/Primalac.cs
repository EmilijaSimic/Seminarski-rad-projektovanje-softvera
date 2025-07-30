using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Zajednicki.Komunikacija
{
    public class Primalac
    {
        StreamReader ulaz;
        public Primalac(Socket socket) {
            NetworkStream stream = new NetworkStream(socket);
            ulaz = new StreamReader(stream);
        }

        public Odgovor Primi()
        {
            return JsonSerializer.Deserialize<Odgovor>(ulaz.ReadLine());
        }

        public Zahtev PrimiZahtevOdKlijenta()
        {
            return JsonSerializer.Deserialize<Zahtev>(ulaz.ReadLine());
        }

        public void Zatvori()
        {
            ulaz.Close();
        }
    }
}
