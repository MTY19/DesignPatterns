using System;
namespace FactoryPattern.v3AbstractFactory
{
	public class TRStyeTurkishPizza : PizzaV3
	{
		public TRStyeTurkishPizza()
		{
			name = "Turkish Pizza";
			sauce = "Turkish sauce";
            dough = "Extra Turkish crush dough";

            topppings.Add("Greted turkish kebab");
        }
	}
}

