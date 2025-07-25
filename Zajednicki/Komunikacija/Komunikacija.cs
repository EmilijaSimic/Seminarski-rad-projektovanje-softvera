using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Zajednicki.Komunikacija
{
    public class Komunikacija
    {
        private Socket socket;
        private NetworkStream stream;
        private StreamReader ulaz;
        private StreamWriter izlaz;

        public Komunikacija(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            ulaz = new StreamReader(stream);
            izlaz = new StreamWriter(stream) { AutoFlush = true };
        }

        public void Posalji(Zahtev zahtev)
        {
            izlaz.WriteLine(JsonSerializer.Serialize(zahtev));
        }

        public Odgovor Primi()
        {
            return JsonSerializer.Deserialize<Odgovor>(ulaz.ReadLine());
        }
    }

}
