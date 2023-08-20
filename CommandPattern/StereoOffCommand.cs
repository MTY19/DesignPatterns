using System;
namespace CommandPattern
{
	public class StereoOffCommand : ICommand
	{
		Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.removeCD();
            stereo.off();
        }

        public void undo()
        {
            stereo.on();
            stereo.insertCD();
        }
    }
}

