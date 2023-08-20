using System;
namespace FactoryPattern.v4AbstractFactory
{
	public class NYPizzaIngredientFactory : IPizzaIngredientFactory
	{
        public Cheese createCheese()
        {
            return new ReggianoCheese();
        }

        public Clams createClams()
        {
            return new FreshClams();
        }

        public Dought createDought()
        {
            return new ThinCrustDought();
        }

        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce createSauce()
        {
            return new MarinaraSauce();
        }

        public Veggies[] createVeggies()
        {
            Veggies[] veggies = { new Gartic(), new Onion() };
            return veggies;
        }
    }
}

