using System;
namespace FactoryPattern.v4AbstractFactory
{
	public abstract class PizzaV4
	{
		public string name;
        public Dought dought;
        public Sauce sauce;
        public Pepperoni Pepperoni;
        public Veggies[] veggies;
        public Cheese cheese;
        public Clams clams;

		public abstract void prepare();

        public void bake()
        {
            Console.WriteLine("baking ...");
        }

        public void cut()
        {
            Console.WriteLine("cutting ...");
        }

        public void box()
        {
            Console.WriteLine("boxing ...");
        }

        public string getName()
        {
            return name;
        }

        public String ToString()
        {
            return "My pizza is " + name;
        }

    }
}

