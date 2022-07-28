using System;
namespace Examen2Poo 
{
    public class Topping1 : Decorador
    {
        public Topping1(HeladoBase orden) : base(orden){}

        public override double Calcular_valor_total()
        {
            Console.WriteLine("Se le agregara el adereso #1");
            var Valor_topping_1 = base.Calcular_valor_total() + 0.50; 
            return Valor_topping_1;
        }
    }
}