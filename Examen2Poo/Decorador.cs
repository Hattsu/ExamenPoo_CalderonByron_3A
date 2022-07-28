using System;
namespace Examen2Poo
{
    public class Decorador : HeladoBase
    {
        protected HeladoBase orden;
        public Decorador (HeladoBase orden)
        {
            this.orden = orden;
        }
        public override double Calcular_valor_total()
        {
            //Console.WriteLine("Calculo estimado del valor total desde la clase decorador");
            return orden.Calcular_valor_total();
        }
        public override string Calcular_sabor()
        {
            return orden.Calcular_sabor();
        }
    }
}
