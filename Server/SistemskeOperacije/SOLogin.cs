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
            List<OpstiDomenskiObjekat> zaposleni = bbp.VratiListuSvih(new Zaposleni());
            Zaposleni login = (Zaposleni)odo;

            foreach (OpstiDomenskiObjekat objekat in zaposleni)
            {
                Zaposleni z = (Zaposleni)objekat;
                if(login.KorisnickoIme.Equals(z?.KorisnickoIme) && login.Lozinka.Equals(z?.Lozinka))
                {
                    return true;
                }
            }
            return false;
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
