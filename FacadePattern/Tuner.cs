using System;
namespace FacadePattern
{
	public class Tuner
	{
        Amplifier amplifier;

        public Tuner()
        {
        }

        public void On()
		{
			Console.WriteLine("Tuner on");
		}

		public void Off()
		{
            Console.WriteLine("Tuner on");
        }

        public void SetAM()
        {
            Console.WriteLine("Tuner set AM");
        }

        public void SetFM()
        {
            Console.WriteLine("Tuner set FM");
        }
    }
}

