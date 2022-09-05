using Reservaturistica2.core;
namespace ReservaTuristica2.Extensions
{
    public  static class CalculoPrecioFinalExtensions
    {

        public static void AddDuplicar(this CalculoPrecioFinal calculoPrecio)
        {
            calculoPrecio.PrecioBrutoFinal = calculoPrecio.PrecioBrutoFinal * 2;
        }

    }
}