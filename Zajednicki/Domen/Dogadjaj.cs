using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    internal class Dogadjaj
    {
        public int Id { get; set; }
        public string Izvodjac { get; set; }
        public string Hala {  get; set; }
        public string Mesto {  get; set; }
        public DateTime Datum { get; set; }
        public double Cena { get; set; }
    }
}
