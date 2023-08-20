using System;
namespace PatternOfPattern
{
    public class Squack : IQuackable
	{
		public Squack()
		{

		}

        public void quack()
        {
            Console.WriteLine("Squack behaviour");
        }
    }
}

