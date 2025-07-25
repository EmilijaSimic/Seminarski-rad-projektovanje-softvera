using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class StavkaPotvrde
    {
        public int Rb { get; set; }
        public Potvrda Potvrda { get; set; }
        public int Kolicina { get; set; }
        public double Cena { get; set; }
        public double Iznos {  get; set; }
        public Dogadjaj Dogadjaj { get; set; }
    }
}
