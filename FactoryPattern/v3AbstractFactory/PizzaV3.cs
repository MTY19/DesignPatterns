using System;
using System.Collections;

namespace FactoryPattern.v3AbstractFactory
{
	public abstract class PizzaV3
	{
        public String name;
        public String dough;
        public string sauce;
        public ArrayList topppings = new ArrayList();

        public void prepare()
        {
            Console.WriteLine("preparing " + name);
            Console.WriteLine("Tossing dough ...");
            Console.WriteLine("Adding sauce");
            Console.WriteLine("Adding toppings: ");
            for (int i = 0; i < topppings.Count; i++)
            {
                Console.WriteLine("  " + topppings[i].ToString());
            }
        }

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
    }
}

