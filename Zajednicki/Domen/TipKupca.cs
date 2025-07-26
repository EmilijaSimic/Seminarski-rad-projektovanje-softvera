using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class TipKupca : OpstiDomenskiObjekat
    {
        public int Id {  get; set; }
        public string Naziv { get; set; }
        public double Popust { get; set; }
    }
}
