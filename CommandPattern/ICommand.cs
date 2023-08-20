using System;
namespace CommandPattern
{
	public interface ICommand
	{
		public void execute();
		public void undo();
	}
}

