using System;
namespace DecoratorPattern
{
	public class Soy : CondimentDecorator
	{
		Beverage beverage;

        public Soy(Beverage beverage) 
        {
            this.beverage = beverage;
        }

        public override double cost()
        {
            return .30 + beverage.cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }
    }
}

