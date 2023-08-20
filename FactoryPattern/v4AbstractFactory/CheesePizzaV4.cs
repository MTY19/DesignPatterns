using System;
namespace FactoryPattern.v4AbstractFactory
{
	public class CheesePizzaV4 : PizzaV4
	{
        IPizzaIngredientFactory pizzaIngredientFactory;

        public CheesePizzaV4(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this.pizzaIngredientFactory = pizzaIngredientFactory;
            name = "Cheese pizzas";
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing " + name);

            dought = pizzaIngredientFactory.createDought();
            sauce = pizzaIngredientFactory.createSauce();
            cheese = pizzaIngredientFactory.createCheese();
        }
    }
}

