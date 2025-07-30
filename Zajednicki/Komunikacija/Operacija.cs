using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Komunikacija
{
    public enum Operacija
    {
        KREIRAJ_DOGADJAJ,
        OBRISI_DOGADJAJ,
        PRETRAZI_DOGADJAJ,
        PROMENI_DOGADJAJ,
        VRATI_LISTU_DOGADJAJA,

        KREIRAJ_KUPCA,
        OBRISI_KUPCA,
        PRETRAZI_KUPCA,
        PROMENI_KUPCA,
        VRATI_LISTU_KUPACA,

        KREIRAJ_POTVRDU,
        PROMENI_POTVRDU,
        VRATI_LISTU_POTVRDA,

        PROMENI_POZICIJU,
        VRATI_LISTU_POZICIJA,

        PROMENI_TIP_KUPCA,
        VRATI_LISTU_TIP_KUPACA,

        VRATI_LISTU_STAVKI_POTVRDE,

        KREIRAJ_ZAPOSLENOG,
        OBRISI_ZAPOSLENOG,
        PROMENI_ZAPOSLENOG,
        PRETRAZI_ZAPOSLENOG,
        VRATI_LISTU_ZAPOSLENIH,

        LOGIN
    }
}
