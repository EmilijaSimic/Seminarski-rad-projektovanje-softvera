using BazaPodataka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Server.SistemskeOperacije
{
    public abstract class OpsteIzvrsenjeSO
    {
        internal BrokerBazePodataka bbp = new BrokerBazePodataka();

        public bool OpsteIzvrsiSO(OpstiDomenskiObjekat odo)
        {
            bool signal = false;
            try
            {
                bbp.OtvoriKonekciju();
                if (proveriOgranicenja(odo))
                {
                    bbp.PokreniTransakciju();
                    if (izvrsiSO(odo))
                    {
                        signal = true;
                        bbp.PotvrdiTransakciju();
                    }
                }
            }
            catch (Exception)
            {
                bbp.OdbaciTransakciju();
            }
            finally {
                bbp.ZatvoriKonekciju();
            }
            return signal;
        }

        abstract public bool proveriOgranicenja(OpstiDomenskiObjekat odo);

        abstract public bool izvrsiSO(OpstiDomenskiObjekat odo);

    }
}
