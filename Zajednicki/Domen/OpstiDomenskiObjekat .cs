using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public interface OpstiDomenskiObjekat
    {
        string VratiNazivTabele();

        string VratiNaziveKolona();

        string VratiVrednostiKolona();

        string VratiVrednostiZaPromenu();

        OpstiDomenskiObjekat ProcitajRed(SqlDataReader ulaz);

        //string VratiNazivPrimarnogKljuca();

        string Uslov();

        string UslovZaPretragu(string filter);

        string Join();

    }
}
