using System;
namespace FactoryPattern.v1
{
	public class PizzaV1 
	{
		public IPizza orderPizza(String type)
		{
            IPizza pizza;

			if (type.Equals("Pepperoni"))
			{
				pizza = new PeppreroniPizza();
			}
			else if (type.Equals("Italiano"))
			{
                pizza = new ItalianoPizza();
            }
            else 
            {
                pizza = new CheesePizza();
            }

			pizza.prepare();
			pizza.bake();
			pizza.cut();
			pizza.box();

			return pizza;
        }
	}
}

