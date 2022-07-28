using System;
namespace Examen2Poo 
{
    public class Topping2:Decorador
    {
        public Topping2(HeladoBase orden) : base(orden){}

        public override double Calcular_valor_total()
        {
            Console.WriteLine("Se le agregara el adereso #2");
            var Valor_topping_2 = base.Calcular_valor_total() + 0.45;   
            return Valor_topping_2;
        }
    }
}