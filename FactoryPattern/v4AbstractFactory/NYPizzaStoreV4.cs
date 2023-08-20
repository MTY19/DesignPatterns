using System;
using FactoryPattern.v4AbstractFactory;

namespace FactoryPattern.v3AbstractFactory
{
	public class NYPizzaStoreV4 : PizzaStoreV4
    {
        public override PizzaV4 createPizza(string type)
        {
            PizzaV4 pizza = null;
            IPizzaIngredientFactory pizzaIngredientFactory = new NYPizzaIngredientFactory();

            if (type.Equals("Cheese"))
            {
                pizza = new CheesePizzaV4(pizzaIngredientFactory);

            }


            return pizza;
        }
    }
}

