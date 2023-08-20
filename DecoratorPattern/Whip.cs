using System;
namespace DecoratorPattern
{
	public class Whip : CondimentDecorator
	{
		Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double cost()
        {
            return .50 + beverage.cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ",Whip";
        }
    }
}

