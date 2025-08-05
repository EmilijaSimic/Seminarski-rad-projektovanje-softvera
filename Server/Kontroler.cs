using Server.SistemskeOperacije;
using Server.SistemskeOperacije.SODogadjaj;
using Server.SistemskeOperacije.SOKupac;
using Server.SistemskeOperacije.SOPotvrda;
using Server.SistemskeOperacije.SOPozicija;
using Server.SistemskeOperacije.SOStavkaPotvrde;
using Server.SistemskeOperacije.SOTipKupca;
using Server.SistemskeOperacije.SOZaposleni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server
{
    internal class Kontroler
    {
        public static Kontroler instance;

        private Kontroler() { }

        public static Kontroler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Kontroler();
                }
                return instance;
            }
        }

        public bool KreirajDogadjaj(Dogadjaj dogadjaj)
        {
            KreirajDogadjaj so = new KreirajDogadjaj();
            return so.OpsteIzvrsiSO(dogadjaj);
        }

        public bool ObrisiDogadjaj(Dogadjaj dogadjaj)
        {
            ObrisiDogadjaj so = new ObrisiDogadjaj();
            return so.OpsteIzvrsiSO(dogadjaj);
        }

        public List<Dogadjaj> PretraziDogadjaj(string filter)
        {
            PretraziDogadjaj so = new PretraziDogadjaj(filter);
            so.OpsteIzvrsiSO(new Dogadjaj());
            return so.Rezultat.Cast<Dogadjaj>().ToList();
        }

        public bool PromeniDogadjaj(Dogadjaj dogadjaj)
        {
            PromeniDogadjaj so = new PromeniDogadjaj();
            return so.OpsteIzvrsiSO(dogadjaj);
        }

        public List<Dogadjaj> VratiListuDogadjaja()
        {
            VratiListuDogadjaja so = new VratiListuDogadjaja();
            so.OpsteIzvrsiSO(new Dogadjaj());
            return so.Rezultat.Cast<Dogadjaj>().ToList();
        }
        public bool KreirajKupca(Kupac kupac)
        {
            KreirajKupca so = new KreirajKupca();
            return so.OpsteIzvrsiSO(kupac);
        }
        public bool ObrisiKupca(Kupac kupac)
        {
            ObrisiKupca so = new ObrisiKupca();
            return so.OpsteIzvrsiSO(kupac);
        }
        public List<Kupac> PretraziKupca(string filter)
        {
            PretraziKupca so = new PretraziKupca(filter);
            so.OpsteIzvrsiSO(new Kupac());
            return so.Rezultat.Cast<Kupac>().ToList();
        }
        public bool PromeniKupca(Kupac kupac)
        {
            PromeniKupca so = new PromeniKupca();
            return so.OpsteIzvrsiSO(kupac);
        }
        public List<Kupac> VratiListuKupaca()
        {
            VratiListuKupaca so = new VratiListuKupaca();
            so.OpsteIzvrsiSO(new Kupac());
            return so.Rezultat.Cast<Kupac>().ToList();
        }

        public bool KreirajPotvrdu(Potvrda potvrda)
        {
            KreirajPotvrdu so = new KreirajPotvrdu();
            return so.OpsteIzvrsiSO(potvrda);
        }
        public bool PromeniPotvrdu(Potvrda potvrda)
        {
            PromeniPotvrdu so = new PromeniPotvrdu();
            return so.OpsteIzvrsiSO(potvrda);
        }
        public List<Potvrda> VratiListuPotvrda()
        {
            VratiListuPotvrda so = new VratiListuPotvrda();
            so.OpsteIzvrsiSO(new Potvrda());
            return so.Rezultat.Cast<Potvrda>().ToList();    
        }
        public bool PromeniPoziciju(Pozicija pozicija)
        {
            PromeniPoziciju so = new PromeniPoziciju();
            return so.OpsteIzvrsiSO(pozicija);
        }
        public List<Pozicija> VratiListuPozicija()
        {
            VratiListuPozicija so = new VratiListuPozicija();
            so.OpsteIzvrsiSO(new Pozicija());
            return so.Rezultat.Cast<Pozicija>().ToList();
        }
        public List<StavkaPotvrde> VratiListuStavkiPotvrde(string filter)
        {
            VratiListuStavkiPotvrde so = new VratiListuStavkiPotvrde(filter);
            so.OpsteIzvrsiSO(new StavkaPotvrde());
            return so.Rezultat.Cast<StavkaPotvrde>().ToList();
        }
        public bool PromeniTipKupca(TipKupca tipKupca)
        {
            PromeniTipKupca so = new PromeniTipKupca();
            return so.OpsteIzvrsiSO(tipKupca);
        }
        public List<TipKupca> VratiListuTipKupaca()
        {
            VratiListuTipKupaca so = new VratiListuTipKupaca();
            so.OpsteIzvrsiSO(new TipKupca());
            return so.Rezultat.Cast<TipKupca>().ToList();
        }
        public bool KreirajZaposlenog(Zaposleni zaposleni)
        {
            KreirajZaposlenog so = new KreirajZaposlenog();
            return so.OpsteIzvrsiSO(zaposleni);
        }
        public bool ObrisiZaposlenog(Zaposleni zaposleni)
        {
            ObrisiZaposlenog so = new ObrisiZaposlenog();
            return so.OpsteIzvrsiSO(zaposleni);
        }
        public List<Zaposleni> PretraziZaposlenog(string filter)
        {
            PretraziZaposlenog so = new PretraziZaposlenog(filter);
            so.OpsteIzvrsiSO(new Zaposleni());
            return so.Rezultat.Cast<Zaposleni>().ToList();
        }
        public bool PromeniZaposlenog(Zaposleni zaposleni)
        {
            PromeniZaposlenog so = new PromeniZaposlenog();
            return so.OpsteIzvrsiSO(zaposleni);
        }
        public List<Zaposleni> VratiListuZaposlenih(string filter)
        {
            VratiListuZaposlenih so = new VratiListuZaposlenih(filter);
            so.OpsteIzvrsiSO(new Zaposleni());
            return so.Rezultat.Cast<Zaposleni>().ToList();
        }

        public bool Login(Zaposleni zaposleni)
        {
            SOLogin so = new SOLogin();
            return so.OpsteIzvrsiSO(zaposleni);
        }
    }
}
