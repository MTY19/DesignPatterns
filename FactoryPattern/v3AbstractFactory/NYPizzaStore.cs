using System;
namespace FactoryPattern.v3AbstractFactory
{
	public class NYPizzaStore : PizzaStore
    {
        public override PizzaV3 createPizza(string type)
        {
            PizzaV3 pizza = null;

            if (type.Equals("Pepperoni"))
            {
                pizza = new NYStyleCheesePizza();
            }
            else if (type.Equals("Turkish"))
            {
                pizza = new NYStyleTurkishPizza();
            }        

            return pizza;
        }
    }
}

