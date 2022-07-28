using System;
namespace Examen2Poo
{
    public class NewBaseType
    {
        public static void Main(string[] arg)
        {

            //Helado #1
            var Helado1 = new HeladoVainilla();
            Console.WriteLine("$"+Helado1.Calcular_sabor());
            Console.WriteLine("$"+Helado1.Calcular_valor_total());

            var Adereso1 = new Topping1(Helado1);
            Console.WriteLine("$"+Adereso1.Calcular_valor_total());

            var Adereso2 = new Topping2(Adereso1);
            Console.WriteLine("$"+Adereso2.Calcular_valor_total());


            //Console.WriteLine();

            var Adereso3 = new Topping3(Adereso2);
            Console.WriteLine("$"+Adereso3.Calcular_valor_total());

            Console.WriteLine();


            //Helado #2
            Console.WriteLine("-----------");
            var Helado2 = new HeladoChocolate();
            Console.WriteLine("$"+Helado2.Calcular_sabor());
            Console.WriteLine("$"+Helado2.Calcular_valor_total());

            var Adereso2_1 = new Topping1(Helado2);
            Console.WriteLine("$"+Adereso1.Calcular_valor_total());

            var Adereso2_2 = new Topping2(Adereso2_1);
            Console.WriteLine("$"+Adereso2_2.Calcular_valor_total());


            

            var Adereso2_3 = new Topping3(Adereso2_2);
            Console.WriteLine("$"+Adereso2_3.Calcular_valor_total());

            Console.WriteLine();

            //Helado #3
            Console.WriteLine("----------");
            var Helado3 = new HeladoMenta();
            Console.WriteLine("$"+Helado3.Calcular_sabor());
            Console.WriteLine("$"+Helado3.Calcular_valor_total());

            var Adereso3_1 = new Topping1(Helado2);
            Console.WriteLine("$"+Adereso3_1.Calcular_valor_total());

            var Adereso3_2 = new Topping2(Adereso3_1);
            Console.WriteLine("$"+Adereso3_2.Calcular_valor_total());


            

            var Adereso3_3 = new Topping3(Adereso3_2);
            Console.WriteLine("$"+Adereso3_3.Calcular_valor_total());

            Console.WriteLine();
        }
    }
}