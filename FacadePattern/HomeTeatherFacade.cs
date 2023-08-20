using System;
namespace FacadePattern
{
	public class HomeTeatherFacade
	{
		Amplifier amplifier;
		CdPlayer cdPlayer;
		DvdPlayer dvdPlayer;
		Screen screen;
		Projector projector;
		Tuner tuner;
        public HomeTeatherFacade(Amplifier amplifier , CdPlayer cdPlayer , DvdPlayer dvdPlayer ,
            Screen screen , Projector projector, Tuner tuner )
        {
            this.amplifier = amplifier;
            this.cdPlayer = cdPlayer;
            this.dvdPlayer = dvdPlayer;
            this.screen = screen;
            this.projector = projector;
            this.tuner = tuner;
        }

        public void WatchMovie()
        {
            Console.WriteLine("Get ready to watch movie");
            screen.Down();
            projector.On();
            amplifier.On();
            amplifier.SetDVD();
            amplifier.SetVolume();
            dvdPlayer.On();
            dvdPlayer.Play();
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            screen.Up();
            projector.Off();
            amplifier.Off();
            dvdPlayer.Stop();
            dvdPlayer.Eject();
            dvdPlayer.Off();
        }
    }
}

