using System;
namespace TemplatePattern
{
	public class Coffee : CaffeineBeverage
    {
        public override void addCondiments()
        {
            Console.WriteLine("Milk added");
        }

        public override void brew()
        {
            Console.WriteLine("Dripping a coffee");
        }
    }
}

