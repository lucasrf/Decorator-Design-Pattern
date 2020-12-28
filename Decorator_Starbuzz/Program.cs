using System;

namespace Decorator_Starbuzz.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 = P | 2 = M | 3 = G
            Beverage espresso = new Espresso(1);
            Beverage decaf = new Decaf(2);
            Beverage houseBlend = new HouseBlend(2);

            CondimentDecorator espressoWithMilk = new Milk(espresso);
            CondimentDecorator decafWithSoy = new Soy(decaf);
            CondimentDecorator houseBlendWithMocha = new Mocha(houseBlend);

            Console.WriteLine("R$" + espressoWithMilk.Cost());
            Console.WriteLine("R$" + decafWithSoy.Cost());
            Console.WriteLine("R$" + houseBlendWithMocha.Cost());

            Console.ReadKey();
        }
    }
}
