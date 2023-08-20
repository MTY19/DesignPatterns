using System;
namespace DecoratorPattern
{
    public class HouseBlend : Beverage
	{
        public HouseBlend()
        {
            description = "House Blend";
        }

        public override double cost()
        {
            return 0.44;
        }
    }
}

