using System;
namespace SingletonPattern
{
	public class MyClass
	{
		private static MyClass instance;
		private MyClass()
		{
		}

		public static MyClass getInstance()
		{
			if (instance == null)
				instance = new MyClass();

			return instance;
        }

		public void writeLogic()
		{
			Console.WriteLine("geldi");
		}
	}
}

