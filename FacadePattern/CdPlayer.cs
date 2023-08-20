using System;
namespace FacadePattern
{
	public class CdPlayer
	{
        Amplifier amplifier;

        public CdPlayer()
        {
        }

        public void On()
        {
            Console.WriteLine("CD Player on");
        }

        public void Off()
        {
            Console.WriteLine("CD Player off");
        }

        public void Eject()
        {
            Console.WriteLine("CD Player eject");
        }

        public void Pause()
        {
            Console.WriteLine("CD Player pause");
        }

        public void Play()
        {
            Console.WriteLine("CD Player play");
        }

        public void Stop()
        {
            Console.WriteLine("CD Player stop");
        }
    }
}

