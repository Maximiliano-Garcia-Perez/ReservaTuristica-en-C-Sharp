
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservaturistica2.core
{
    public class CalculoPrecioFinal
    {
        public Reserva Reserva { get; private set; }
        public double PrecioBrutoFinal { get; set; }
        public CalculoPrecioFinal(Reserva reserva)
        {
            Reserva = reserva;
        }
        public void AddDescuentoContinente() 
        {
            if (Reserva.Continente == Continente.America)
            {
                PrecioBrutoFinal -= (PrecioBrutoFinal * 0.05);
            }


        }
        public void AddAumentoCantDias() 
        {
            PrecioBrutoFinal = PrecioBrutoFinal * Reserva.CantDias;
        }
        public void AddDescuentoPorSenia() 
        {
            if (Reserva.TieneSenia)
            {
                PrecioBrutoFinal -= (PrecioBrutoFinal * 0.05);
            }


        }
        public void AddAumentoCantPersonas() 
        {


        }
        public void AddAumentoTransporte() 
        {
            switch (Reserva.transporte)
            {
                case Transporte.Tierra:
                    PrecioBrutoFinal += (PrecioBrutoFinal * 0.3);
                    break;
                case Transporte.Aire:
                    PrecioBrutoFinal += (PrecioBrutoFinal * 0.4);
                    break;
                case Transporte.Mar:
                    PrecioBrutoFinal += (PrecioBrutoFinal * 0.5);
                    break;
                default:
                    break;
            }

        }


    }
}
