using System;
namespace FacadePattern
{
	public class DvdPlayer
	{
        Amplifier amplifier;

        public DvdPlayer()
        {
        }

        public void On()
        {
            Console.WriteLine("DVD Player on");
        }

        public void Off()
        {
            Console.WriteLine("DVD Player off");
        }

        public void Eject()
        {
            Console.WriteLine("DVD Player eject");
        }

        public void Pause()
        {
            Console.WriteLine("DVD Player pause");
        }

        public void Play()
        {
            Console.WriteLine("DVD Player play");
        }

        public void Stop()
        {
            Console.WriteLine("DVD Player stop");
        }

    }
}

