using System;
namespace PatternOfPattern
{
	public class Quack : IQuackable
	{
		public Quack()
		{
		}

        public void quack()
        {
            //quack
            Console.WriteLine("Quack behaviour");

        }
    }
}

