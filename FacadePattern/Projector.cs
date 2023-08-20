using System;
namespace FacadePattern
{
	public class Projector
	{
		DvdPlayer dvdPlayer;

        public Projector(DvdPlayer dvdPlayer)
        {
            this.dvdPlayer = dvdPlayer;
        }

        public void On()
        {
            Console.WriteLine("Projector on");
        }

        public void Off()
        {
            Console.WriteLine("Projector off");
        }

        public void TvMode()
        {
            Console.WriteLine("TV mode activated");
        }
    }
}

