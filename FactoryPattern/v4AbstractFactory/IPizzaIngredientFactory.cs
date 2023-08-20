using System;
namespace FactoryPattern.v4AbstractFactory
{
	public interface IPizzaIngredientFactory
	{
		public Dought createDought();
        public Sauce createSauce();
        public Cheese createCheese();
        public Veggies[] createVeggies();
        public Pepperoni createPepperoni();
        public Clams createClams();
    }
}

