using System;
namespace Examen2Poo 
{
public class HeladoVainilla:HeladoBase
    {
        public override double Calcular_valor_total()
        {
            Console.Write("Valor total del Helado: ");
            var Valor_1 = 1.50;
            return Valor_1;
        }

        public override string Calcular_sabor()
        {
            Console.WriteLine("Sabor del helado: ");
            var Sabor_1 = "Vainilla";
            return Sabor_1;
        }
    }
}