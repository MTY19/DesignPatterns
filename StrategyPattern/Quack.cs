using System;
namespace StrategyPattern
{
	public class Quack : IQuackBehaviour
	{
        public void quack()
        {
            //quack
            Console.WriteLine("Quack behaviour");

        }
    }
}

