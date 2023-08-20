using System;
namespace FactoryPattern
{
	public class TurkishPizza : IPizza
	{
        public void bake()
        {
            Console.WriteLine(this.GetType().ToString() + " is Baking ...");
        }

        public void box()
        {
            Console.WriteLine(this.GetType().ToString() + " is Boxing ...");
        }

        public void cut()
        {
            Console.WriteLine(this.GetType().ToString() + " is Cutting ...");
        }

        public void prepare()
        {
            Console.WriteLine(this.GetType().ToString() + " is Preparing ...");
        }
    }
}

