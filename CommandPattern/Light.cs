using System;
namespace CommandPattern
{
	public class Light 
	{
		public string name;

        public Light(string name)
        {
            this.name = name;
        }

        public void on()
		{
			Console.WriteLine(name + " Light On");
		}

        public void off()
        {
            Console.WriteLine(name + " Light Off");
        }
    }
}

