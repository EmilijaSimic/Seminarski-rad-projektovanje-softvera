﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.SistemskeOperacije.SOKupac
{
    internal class VratiListuKupaca : OpsteIzvrsenjeSO
    {
        public List<OpstiDomenskiObjekat> Rezultat {  get; set; }
        public override bool izvrsiSO(OpstiDomenskiObjekat odo)
        {
            Rezultat = bbp.VratiListuSvihSaJoin(new Kupac());
            return true;
        }

        public override bool proveriOgranicenja(OpstiDomenskiObjekat odo)
        {
            return true;
        }
    }
}
