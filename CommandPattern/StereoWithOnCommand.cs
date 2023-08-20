using System;
namespace CommandPattern
{
	public class StereoWithOnCommand : ICommand
	{
		Stereo stereo;

        public StereoWithOnCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.insertCD();
            stereo.on();
        }

        public void undo()
        {
            stereo.off();
            stereo.removeCD();
        }
    }
}

