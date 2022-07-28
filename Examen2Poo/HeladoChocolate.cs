using System;
namespace Examen2Poo 
{
    public class HeladoChocolate : HeladoBase
    {
        public override double Calcular_valor_total()
        {
            Console.Write("Valor total del Helado: ");
            var Valor_2 = 1.25;
            return Valor_2;
        }
        public override string Calcular_sabor()
        {
            Console.WriteLine("Sabor del helado: ");
            var Sabor_2 = "Chocolate";
            return Sabor_2;
        }
    }
}