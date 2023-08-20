using System;
namespace FactoryPattern.v3AbstractFactory
{
	public abstract class PizzaStore
	{
        public PizzaV3 orderPizza(string type)
        {
            PizzaV3 pizza = createPizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        public abstract PizzaV3 createPizza(String type);
    }
}

