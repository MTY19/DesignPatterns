using System;
namespace CommandPattern
{
	public class NoCommand : ICommand
	{
		public NoCommand()
		{
		}

        public void execute()
        {
            
        }

        public void undo()
        {
             
        }
    }
}

