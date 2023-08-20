using System;
namespace CommandPattern
{
	public class Stereo
	{
        public string name;

        public Stereo(string name)
        {
            this.name = name;
        }

        public void on()
        {
            Console.WriteLine(name + " Stereo On");
        }

        public void insertCD()
        {
            Console.WriteLine(name + " CD inserted");
        }

        public void removeCD()
        {
            Console.WriteLine(name +" CD removed");
        }

        public void off()
        {
            Console.WriteLine(name + " Stereo Off");
        }
    }
}

