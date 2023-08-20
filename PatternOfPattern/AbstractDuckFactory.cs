using System;
namespace PatternOfPattern
{
	public abstract class AbstractDuckFactory
	{
		public abstract Duck CreateMallardDuck();
        public abstract Duck CreateNormalDuck();
	}
}

