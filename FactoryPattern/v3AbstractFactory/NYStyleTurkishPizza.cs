using System;
namespace FactoryPattern.v3AbstractFactory
{
	public class NYStyleTurkishPizza : PizzaV3
	{
		public NYStyleTurkishPizza()
		{
            name = "NY Turkish Style kebab and cheese pizza";
            dough = "Extra Train crush dough";
            sauce = "Turkish Sauce";

            topppings.Add("Greted kebab");
        }

        void cut()
        {
            Console.WriteLine("cutting into pizza square slices");
        }
	}
}

