using System;
namespace DecoratorPattern
{
	public abstract class Beverage
	{
	    public String description = "Beverage whip";

		public virtual string getDescription()
		{
			return description;
		}

		public abstract double cost();
	}
}

