using System;
namespace Examen2Poo {
    public class Topping3 : Decorador
    {
        public Topping3(HeladoBase orden) : base(orden){}

        public override double Calcular_valor_total()
        {
            Console.WriteLine("Se le agregara el adereso #3");
            var Valor_topping_3 = base.Calcular_valor_total() + 0.35;   
            return Valor_topping_3;
        }
    }
}