using System;
using FactoryPattern.v4AbstractFactory;

namespace FactoryPattern.v4AbstractFactory
{
	public abstract class PizzaStoreV4
	{
        public PizzaV4 orderPizza(string type)
        {
            PizzaV4 pizza = createPizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        public abstract PizzaV4 createPizza(String type);
    }
}

