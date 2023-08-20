using System;
namespace StrategyPattern
{
	public class Squack : IQuackBehaviour
	{
        public void quack()
        {
            //squeak behaviour
            Console.WriteLine("Squack behaviour");
        }
    }
}

