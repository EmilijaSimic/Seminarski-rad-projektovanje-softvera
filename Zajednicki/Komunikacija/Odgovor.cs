using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Komunikacija
{
    public class Odgovor
    {
        public bool Uspesno { get; set; }
        public Operacija Operacija { get; set; }
        public object Podaci { get; set; }
    }
}
