using System;
namespace ProxyPattern.FirstExample
{
    public class FileLogger : ILogger
	{
        public void Log(string message)
        {
            message = $"[{DateTime.Now:dd.MM.yyyy}] - {message}";
            File.AppendAllText("message.log", message);
        }

        public void Log(IEnumerable<string> messages)
        {
            File.AppendAllText("messages.log", string.Join(Environment.NewLine, messages));
        }
    }
}

