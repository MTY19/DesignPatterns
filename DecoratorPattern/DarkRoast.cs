using System;
namespace DecoratorPattern
{
    public class DarkRoast : Beverage
	{
        public DarkRoast()
        {
            description = "DarkRoast";
        }

        public override double cost()
        {
            return 0.10;
        }
    }
}

