using System;
namespace StrategyPattern
{
	public class MallardDuck : Duck
	{
		public MallardDuck()
		{
			setFlyBehaviour(new FlyWithWings());
			setQuackBehaviour(new Squack());
		}

        public override void display()
        {
			Console.WriteLine("Mallard Duck Displaying");
        }
    }
}

