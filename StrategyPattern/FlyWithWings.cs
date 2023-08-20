using System;
namespace StrategyPattern
{
	public class FlyWithWings : IFlyBehaviour
	{
        public void fly()
        {
            //wing fly
            Console.WriteLine("FlyWithWings behaviour");

        }
    }
}

