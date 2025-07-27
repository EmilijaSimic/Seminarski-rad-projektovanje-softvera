using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.SistemskeOperacije
{
    public class SOLogin : OpsteIzvrsenjeSO
    {
        public override bool izvrsiSO(OpstiDomenskiObjekat odo)
        {
            throw new NotImplementedException();
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {

            if(odo is Zaposleni zaposleni)
            {
                if(zaposleni.KorisnickoIme != null && zaposleni.Lozinka != null)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
