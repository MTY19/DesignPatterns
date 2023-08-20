using System;
namespace FactoryPattern.v3AbstractFactory
{
	public class TRPizzaStore : PizzaStore
    {
        public override PizzaV3 createPizza(string type)
        {
            PizzaV3 pizza = null;

            if (type.Equals("Bolmalzemos"))
            {
                pizza = new NYStyleTurkishPizza();
            }
            else if (type.Equals("Turkish"))
            {
                pizza = new TRStyeTurkishPizza();
            }

            return pizza;
        }
    }
}

