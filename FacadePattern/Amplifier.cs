using System;
namespace FacadePattern
{
	public class Amplifier
	{
		CdPlayer cdPlayer;
		DvdPlayer dvdPlayer;
		Tuner tuner;

        public Amplifier(CdPlayer cdPlayer, DvdPlayer dvdPlayer, Tuner tuner)
        {
            this.cdPlayer = cdPlayer;
            this.dvdPlayer = dvdPlayer;
            this.tuner = tuner;
        }

        public void On()
        {
            Console.WriteLine("Amplifier Player on");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier Player off");
        }

        public void SetCD()
        {
            Console.WriteLine("CD Set");
        }

        public void SetDVD()
        {
            Console.WriteLine("DVD set");
        }

        public void SetTuner()
        {
            Console.WriteLine("Tuner set");
        }

        public void SetVolume()
        {
            Console.WriteLine("Volume set");
        }
    }
}

