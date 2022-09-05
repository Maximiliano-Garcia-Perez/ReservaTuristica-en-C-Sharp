using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservaturistica2.core
{
    public class Reserva
    {
        public int CantDias { get; set; }
        public  Continente Continente { get; set; }
        public bool TieneSenia { get; set; }
        public Transporte transporte { get; set; }
        public double PrecioNeto { get; set; }


    }
}
