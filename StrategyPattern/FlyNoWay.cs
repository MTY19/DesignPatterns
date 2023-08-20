using System;
namespace StrategyPattern
{
	public class FlyNoWay : IFlyBehaviour
	{
        public void fly()
        {
            //fly no way
            Console.WriteLine("FlyNoWay behaviour");
        }
    }
}

