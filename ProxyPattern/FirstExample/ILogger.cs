using System;
namespace ProxyPattern.FirstExample
{
	public interface ILogger
	{
		void Log(string message);
		void Log(IEnumerable<string> messages);
    }
}

