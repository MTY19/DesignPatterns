using System;
using System.Text;

namespace CommandPattern
{
	public class RemoteControl
	{
		public List<ICommand> onCommands;
        public List<ICommand> offCommands;
        ICommand undoCommand;

        public RemoteControl()
        {
            this.onCommands = new List<ICommand>();
            this.offCommands = new List<ICommand>();
            undoCommand = new NoCommand();
        }

        public void setCommand(int slot,ICommand onCommand, ICommand offCommand)
        {
            onCommands.Add(onCommand);
            offCommands.Add(offCommand);
        }

        public void onButtonWasPressed(int slot)
        {
            onCommands[slot].execute();
            undoCommand = onCommands[slot];
        }

        public void offButtonWasPressed(int slot)
        {
            offCommands[slot].execute();
            undoCommand = offCommands[slot];
        }

        public void undoWasPressed()
        {
            undoCommand.undo();
        }

        public override String ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("");
            for (int i = 0; i < onCommands.Count; i++)
            {
                stringBuilder.Append("[slot " + i + "] " + onCommands[i].GetType().Name.ToString() + "  " + offCommands[i].GetType().Name.ToString() + "\n");
            }

            return stringBuilder.ToString();
        }
    }
}

