using System;
namespace StrategyPattern
{
	public abstract class Duck
	{
		public Duck()
		{
		}

		IFlyBehaviour flyBehaviour;
		IQuackBehaviour quackBehaviour;

		public void swim()
		{
			Console.WriteLine("All Duck can Swim");
		}

		public abstract void display();

		public void performQuack()
		{
			quackBehaviour.quack();
		}

		public void performFly()
		{
			flyBehaviour.fly();
		}

		public void setFlyBehaviour(IFlyBehaviour flyBehaviour)
		{
			this.flyBehaviour = flyBehaviour;
        }

        public void setQuackBehaviour(IQuackBehaviour quackBehaviour)
        {
            this.quackBehaviour = quackBehaviour;
        }
    }
}

