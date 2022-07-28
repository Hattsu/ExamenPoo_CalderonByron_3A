using System;
namespace Examen2Poo 
{
    public class HeladoMenta : HeladoBase
    {
        public override double Calcular_valor_total()
        {
            Console.Write("Valor total del Helado: ");
            var Valor_3 = 1;
            return Valor_3;
        }

        public override string Calcular_sabor()
        {
            Console.WriteLine("Sabor del helado: ");
            var Sabor_3 = "Menta";
            return Sabor_3;
        }
    }
}