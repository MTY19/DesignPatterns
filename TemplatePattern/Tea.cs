using System;
namespace TemplatePattern
{
	public class Tea : CaffeineBeverage
	{
        public override void addCondiments()
        {
            Console.WriteLine("Sugar added");
        }

        public override void brew()
        {
            Console.WriteLine("Dripping a tea");
        }

        public override bool customerWantCondiments()
        {
            return false;
        }
    }
}

