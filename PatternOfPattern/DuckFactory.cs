using System;
namespace PatternOfPattern
{
	public class DuckFactory : AbstractDuckFactory
	{
        public override Duck CreateMallardDuck() => new QuackCounter(new MallardDuck());

        public override Duck CreateNormalDuck() => new QuackCounter(new NormalDuck());
    }
}

