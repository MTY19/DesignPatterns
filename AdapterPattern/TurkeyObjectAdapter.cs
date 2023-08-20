using System;
namespace AdapterPattern
{
	public class TurkeyObjectAdapter : IDuck
	{
        Turkey turkey;
		public TurkeyObjectAdapter()
		{
            turkey = new Turkey();
        }

        public void fly()
        {
            turkey.Fly();
        }

        public void swim()
        {
            Console.WriteLine("Turkey cannot swim");
        }
    }
}

