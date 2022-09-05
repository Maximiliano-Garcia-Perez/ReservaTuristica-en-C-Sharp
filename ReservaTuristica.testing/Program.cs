using ReservaTuristica2.Extensions;
using Reservaturistica2.core;



CalculoPrecioFinal calculoPrecioFinal = new CalculoPrecioFinal(new Reserva()
{
    CantDias = 3,
    Continente = Continente.America,
    TieneSenia = false,
    transporte = Transporte.Mar,
    PrecioNeto = 2500

}) ; // R = { CantDias: 3, Continente: America, TieneSeña: NO, Transporte: Mar, PrecioNeto: 2500 }

// PrecioBrutoFinal = PrecioNeto

calculoPrecioFinal.AddAumentoCantDias(); // PrecioBrutoFinal = 7750

calculoPrecioFinal.AddDescuentoContinente(); // PrecioBrutoFinal = 7362.5

calculoPrecioFinal.AddDescuentoPorSenia(); // PrecioBrutoFinal = 7362.5

calculoPrecioFinal.AddAumentoTransporte(); // PrecioBrutoFinal = 11043.75

calculoPrecioFinal.AddDuplicar(); // Es un método personalizado | PrecioBrutoFinal = 22,087.5

Console.WriteLine(calculoPrecioFinal.PrecioBrutoFinal); // Se espera: "22087.5"



